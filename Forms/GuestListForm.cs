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

            this.KeyPreview = true;
            this.KeyDown += GuestListForm_KeyDown;

            GuestListTable.ReadOnly = false;
            GuestListTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GuestListTable.MultiSelect = false;
            GuestListTable.AllowUserToAddRows = false;
            GuestListTable.CellEndEdit += GuestListTable_CellEndEdit;
            LoadGuests();
        }

        // Обробка клавіш: Enter - підтвердження, Esc - закриття, F1 - допомога
        private void GuestListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(
                    "Ця форма дозволяє редагувати дані гостей.\n" +
                    "Виділіть рядок, змініть значення у таблиці та натисність 'Enter'.\n",
                    "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EditButton.PerformClick();
                e.Handled = true;
            }
        }

        // Завантаження гостей із готелю до таблиці
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

        // Збереження змін у властивостях гостя після редагування таблиці
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

                    HighlightRowTemporarily(row, Color.LightGreen);
                }
            }
        }

        // Підсвічення зміненого рядка в таблиці
        private async void HighlightRowTemporarily(DataGridViewRow row, Color highlightColor)
        {
            Color originalColor = row.DefaultCellStyle.BackColor;
            row.DefaultCellStyle.BackColor = highlightColor;

            await Task.Delay(2000);

            row.DefaultCellStyle.BackColor = originalColor;
        }

        // Обробник натискання кнопки "Редагувати"
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
                MessageBox.Show(
                    $"Оберіть властивість гостя для зміни, " +
                    $"після чого натисніть 'Enter' для прийняття змін.", 
                    "Інструкція", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
            else
            {
                MessageBox.Show("Гість не знайдений.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GuestListTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}