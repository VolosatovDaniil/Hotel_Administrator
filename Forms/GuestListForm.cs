using Hotel_Administrator.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Administrator.Forms
{
    public partial class GuestListForm : Form
    {
        public GuestListForm()
        {
            InitializeComponent();
            GuestListTable.ReadOnly = false;
            GuestListTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GuestListTable.MultiSelect = false;
            GuestListTable.AllowUserToAddRows = false;
            GuestListTable.CellEndEdit += GuestListTable_CellEndEdit;
            LoadGuests();
        }

        private void LoadGuests()
        {
            var guests = Hotel.Instance.Guests;

            if (GuestListTable.Columns.Count == 0)
            {
                GuestListTable.Columns.Add("LastName", "Прізвище");
                GuestListTable.Columns.Add("FirstName", "Ім'я");
                GuestListTable.Columns.Add("PassportId", "Паспорт");
                GuestListTable.Columns.Add("RoomNumber", "Номер кімнати");
                GuestListTable.Columns.Add("CheckInDate", "Дата заїзду");
                GuestListTable.Columns.Add("CheckOutDate", "Дата виїзду");
            }

            GuestListTable.Rows.Clear();

            foreach (var guest in guests)
            {
                GuestListTable.Rows.Add(
                    guest.LastName,
                    guest.FirstName,
                    guest.PassportId,
                    guest.RoomNumber,
                    guest.CheckInDate.ToShortDateString(),
                    guest.CheckOutDate.ToShortDateString()
                );
            }
        }

        private void GuestListTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GuestListTable.Rows[e.RowIndex];
                string passportId = row.Cells[2].Value?.ToString();

                var guest = Hotel.Instance.Guests.FirstOrDefault(g => g.PassportId == passportId);
                if (guest != null)
                {
                    guest.LastName = row.Cells[0].Value?.ToString();
                    guest.FirstName = row.Cells[1].Value?.ToString();

                    if (int.TryParse(row.Cells[3].Value?.ToString(), out int roomNumber))
                        guest.RoomNumber = roomNumber;

                    if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime checkIn))
                        guest.CheckInDate = checkIn;

                    if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime checkOut))
                        guest.CheckOutDate = checkOut;

                    // Підсвічення зміненого рядка
                    HighlightRowTemporarily(row, Color.LightGreen);
                }
            }
        }

        private async void HighlightRowTemporarily(DataGridViewRow row, Color highlightColor)
        {
            Color originalColor = row.DefaultCellStyle.BackColor;
            row.DefaultCellStyle.BackColor = highlightColor;

            await Task.Delay(2000);

            row.DefaultCellStyle.BackColor = originalColor;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (GuestListTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть гостя для редагування.");
                return;
            }

            DataGridViewRow row = GuestListTable.SelectedRows[0];
            string passportId = row.Cells[2].Value.ToString();

            var guest = Hotel.Instance.Guests.FirstOrDefault(g => g.PassportId == passportId);
            if (guest != null)
            {
                MessageBox.Show($"Оберіть властивість гостя для зміни, після чого натисніть 'Enter' для прийняття змін.");
            }
            else
            {
                MessageBox.Show("Гість не знайдений.");
            }
        }

        private void GuestListTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}