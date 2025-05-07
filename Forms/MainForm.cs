using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Hotel_Administrator.Models;
using Hotel_Administrator.Forms;

namespace Hotel_Administrator
{
    public partial class MainForm : Form
    {
        private Hotel hotel;

        public MainForm()
        {
            InitializeComponent();
            hotel = Hotel.Instance;

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

            SearchResultsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchResultsTable.MultiSelect = false;

            UpdateAllActionButtons();
        }

        private void AttachCursorEvents(Button button)
        {
            button.MouseEnter += (s, e) => button.Cursor = Cursors.Hand;
            button.MouseLeave += (s, e) => button.Cursor = Cursors.Default;
        }

        private void UpdateAllActionButtons()
        {
            CheckInButton.Enabled = true;
            CheckOutButton.Enabled = true;
            EditRoomsButton.Enabled = true;
            ViewGuestsButton.Enabled = true;
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
            SearchResultsTable.Rows.Clear();

            if (string.IsNullOrEmpty(query))
            {
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

            foreach (var guest in matchingGuests)
            {
                AddGuestToTable(guest);
            }
            UpdateAllActionButtons();
        }

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

                        var room = hotel.Rooms.FirstOrDefault(r => r.Number == guest.RoomNumber);
                        if (room != null)
                        {
                            room.CurrentGuests.Add(guest);
                        }
                        AddGuestToTable(guest);
                        UpdateAllActionButtons();
                    }
                }
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Guest guest = null;

            if (SearchResultsTable.SelectedRows.Count > 0)
            {
                string selectedPassportId = SearchResultsTable.SelectedRows[0].Cells[2].Value.ToString();
                guest = hotel.Guests.FirstOrDefault(g => g.PassportId == selectedPassportId);
            }

            using (var checkOutForm = guest != null ? new CheckOutForm(guest) : new CheckOutForm())
            {
                if (checkOutForm.ShowDialog() == DialogResult.OK)
                {
                    var passportId = checkOutForm.PassportId;
                    RefreshTableFromHotel();
                    MessageBox.Show("Гість успішно виселений.");
                }
            }
        }

        private void EditRoomsButton_Click(object sender, EventArgs e)
        {
            using (var editRoomsForm = new EditRoomsForm())
            {
                editRoomsForm.ShowDialog();
                RefreshTableFromHotel();
            }
        }

        private void ViewGuestsButton_Click(object sender, EventArgs e)
        {
            using (var guestListForm = new GuestListForm())
            {
                guestListForm.ShowDialog();
                RefreshTableFromHotel();
            }
        }

        private void RefreshTableFromHotel()
        {
            SearchResultsTable.Rows.Clear();

            foreach (var guest in hotel.Guests)
            {
                AddGuestToTable(guest);
            }
            UpdateAllActionButtons();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) { }

        private void SearchResultsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}