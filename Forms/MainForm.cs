using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Hotel_Administrator.Models;
using Hotel_Administrator.Forms;
using Hotel_Administrator.Models.Hotel_Administrator.Models;

namespace Hotel_Administrator
{
    public partial class MainForm : Form
    {
        private Hotel hotel;

        public MainForm()
        {
            InitializeComponent();

            hotel = new Hotel();

            // Під'єднуємо події кнопок
            AttachCursorEvents(CheckInButton);
            AttachCursorEvents(CheckOutButton);
            AttachCursorEvents(EditRoomsButton);
            AttachCursorEvents(ViewGuestsButton);

            // Обробка натискання Enter у полі пошуку
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;

            // Завантаження початкових налаштувань форми
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Налаштування DataGridView для відображення результатів пошуку
            SearchResultsTable.ColumnCount = 6;
            SearchResultsTable.Columns[0].Name = "Прізвище";
            SearchResultsTable.Columns[1].Name = "Ім'я";
            SearchResultsTable.Columns[2].Name = "Паспорт";
            SearchResultsTable.Columns[3].Name = "Кімната";
            SearchResultsTable.Columns[4].Name = "Заселення";
            SearchResultsTable.Columns[5].Name = "Виселення";

            SearchResultsTable.ReadOnly = true;
            SearchResultsTable.AllowUserToAddRows = false;
            SearchResultsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateAllActionButtons();
        }

        // Зміна курсору
        private void AttachCursorEvents(Button button)
        {
            button.MouseEnter += (s, e) => button.Cursor = Cursors.Hand;
            button.MouseLeave += (s, e) => button.Cursor = Cursors.Default;
        }

        private void UpdateButtonState(Button button, bool enabled)
        {
            button.Enabled = enabled;
        }

        private void UpdateAllActionButtons()
        {
            bool hasRows = SearchResultsTable.Rows.Count > 0;

            UpdateButtonState(CheckInButton, true);
            UpdateButtonState(CheckOutButton, hasRows);
            UpdateButtonState(EditRoomsButton, hasRows);
            UpdateButtonState(ViewGuestsButton, hasRows);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) { }

        private void SearchResultsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Обробник для натискання Enter у полі пошуку
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        // Обробка кнопки пошуку
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))
            {
                SearchResultsTable.Rows.Clear();
                UpdateAllActionButtons();
                return;
            }

            var matchingGuests = hotel.Guests
                .Where(g =>
                    g.FirstName.ToLower().Contains(query) ||
                    g.LastName.ToLower().Contains(query) ||
                    g.PassportId.ToLower().Contains(query) ||
                    g.RoomNumber.ToString().Contains(query))
                .ToList();

            SearchResultsTable.Rows.Clear();

            foreach (var guest in matchingGuests)
            {
                AddGuestToTable(guest);
            }

            UpdateAllActionButtons();
        }

        // Додавання гостя до таблиці результатів
        private void AddGuestToTable(Guest guest)
        {
            SearchResultsTable.Rows.Add(
                guest.LastName,
                guest.FirstName,
                guest.PassportId,
                guest.RoomNumber,
                guest.CheckInDate.ToShortDateString(),
                guest.CheckOutDate.ToShortDateString()
            );
        }

        // Обробка кнопки "Заселити"
        private void CheckInButton_Click(object sender, EventArgs e)
        {
            using (var checkInForm = new Check_inForm())
            {
                if (checkInForm.ShowDialog() == DialogResult.OK)
                {
                    var guest = checkInForm.CreatedGuest;
                    if (guest != null)
                    {
                        hotel.Guests.Add(guest);
                        AddGuestToTable(guest);
                        UpdateAllActionButtons();
                    }
                }
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (!CheckOutButton.Enabled) return;
            // TODO: Додати логіку виселення
        }

        private void EditRoomsButton_Click(object sender, EventArgs e)
        {
            if (!EditRoomsButton.Enabled) return;
            // TODO: Додати логіку редагування номерів
        }

        private void ViewGuestsButton_Click(object sender, EventArgs e)
        {
            if (!ViewGuestsButton.Enabled) return;
            // TODO: Додати логіку перегляду гостей
        }
    }
}