using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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

            AttachCursorEvents(CheckInButton);
            AttachCursorEvents(CheckOutButton);
            AttachCursorEvents(EditRoomsButton);
            AttachCursorEvents(ViewGuestsButton);

            SearchTextBox.KeyDown += SearchTextBox_KeyDown;

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

        // Логіка для кнопок: CheckInButton; CheckOutButton; EditRoomsButton; ViewGuestsButton
        private void AttachCursorEvents(Button button)
        {
            button.MouseEnter += (s, e) => button.Cursor = button.Enabled ? Cursors.Hand : Cursors.No;
            button.MouseLeave += (s, e) => button.Cursor = Cursors.Default;
        }

        private void UpdateButtonState(Button button, bool enabled)
        {
            button.Enabled = enabled;
            button.Cursor = enabled ? Cursors.Hand : Cursors.No;
        }

        private void UpdateAllActionButtons()
        {
            bool hasRows = SearchResultsTable.Rows.Count > 0;

            UpdateButtonState(CheckInButton, hasRows);
            UpdateButtonState(CheckOutButton, hasRows);
            UpdateButtonState(EditRoomsButton, hasRows);
            UpdateButtonState(ViewGuestsButton, hasRows);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchResultsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim().ToLower();

            // Якщо поле пошуку порожнє — очищаємо таблицю
            if (string.IsNullOrEmpty(query))
            {
                SearchResultsTable.Rows.Clear();
                UpdateAllActionButtons();
                return;
            }

            // Пошук збігів серед гостей
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
                SearchResultsTable.Rows.Add(
                    guest.LastName,
                    guest.FirstName,
                    guest.PassportId,
                    guest.RoomNumber,
                    guest.CheckInDate.ToShortDateString(),
                    guest.CheckOutDate.ToShortDateString()
                );
            }

            UpdateAllActionButtons();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            if (!CheckInButton.Enabled) return;
            // TODO: Додати логіку заселення
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