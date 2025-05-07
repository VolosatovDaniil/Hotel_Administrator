using System;
using System.Linq;
using System.Windows.Forms;
using Hotel_Administrator.Models;

namespace Hotel_Administrator.Forms
{
    public partial class CheckOutForm : Form
    {
        public Guest GuestToCheckOut { get; private set; }

        public string PassportId => GuestToCheckOut?.PassportId ?? PassportTextBox.Text;

        public CheckOutForm()
        {
            InitializeComponent();
            CheckOutDatePicker.Value = DateTime.Today;
        }

        public CheckOutForm(Guest guest) : this()
        {
            if (guest != null)
            {
                GuestToCheckOut = guest;
                LastNameTextBox.Text = guest.LastName;
                FirstNameTextBox.Text = guest.FirstName;
                PassportTextBox.Text = guest.PassportId;
                RoomNumberBox.Text = guest.RoomNumber.ToString();
                CheckInDatePicker.Value = guest.CheckInDate;
                CheckOutDatePicker.Value = DateTime.Today;

                LastNameTextBox.ReadOnly = true;
                FirstNameTextBox.ReadOnly = true;
                PassportTextBox.ReadOnly = true;
                RoomNumberBox.ReadOnly = true;
                CheckInDatePicker.Enabled = false;
            }
        }

        private void ConfirmCheckOutButton_Click(object sender, EventArgs e)
        {
            if (GuestToCheckOut == null)
            {
                string passport = PassportTextBox.Text.Trim();
                GuestToCheckOut = Hotel.Instance.Guests.FirstOrDefault(g => g.PassportId == passport);

                if (GuestToCheckOut == null)
                {
                    MessageBox.Show("Гість з таким паспортом не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Оновлення дати виїзду
            GuestToCheckOut.CheckOutDate = CheckOutDatePicker.Value;

            // Створення квитанції
            var receipt = new Receipt(
                Hotel.Instance.GenerateReceiptId(),
                GuestToCheckOut.PassportId,
                GuestToCheckOut.CheckOutDate,
                Hotel.Instance.CalculateCharge(GuestToCheckOut),
                ReceiptType.CheckOut
            );

            // Додавання квитанцію в список
            Hotel.Instance.Receipts.Add(receipt);

            // Видалення гостя зі списку
            Hotel.Instance.Guests.Remove(GuestToCheckOut);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}