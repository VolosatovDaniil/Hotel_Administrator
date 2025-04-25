using System;
using System.Windows.Forms;
using Hotel_Administrator.Models;

namespace Hotel_Administrator.Forms
{
    public partial class Check_inForm : Form
    {
        public Guest CreatedGuest { get; private set; }

        public Check_inForm()
        {
            InitializeComponent();
        }

        // Обробник кнопки "Підтвердити заселення"
        private void ConfirmCheckInButton_Click(object sender, EventArgs e)
        {
            Guest guest = GetGuestIfValid();
            if (guest != null)
            {
                CreatedGuest = guest;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        // Перевірка введених даних
        private Guest GetGuestIfValid()
        {
            string lastName = LastNameTextBox.Text.Trim();
            string firstName = FirstNameTextBox.Text.Trim();
            string passport = PassportTextBox.Text.Trim();
            string roomText = RoomNumberBox.Text.Trim();
            DateTime checkIn = CheckInDatePicker.Value;
            DateTime checkOut = CheckOutDatePicker.Value;

            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(passport) ||
                string.IsNullOrWhiteSpace(roomText))
            {
                MessageBox.Show("Усі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!int.TryParse(roomText, out int roomNumber))
            {
                MessageBox.Show("Номер кімнати має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (checkIn >= checkOut)
            {
                MessageBox.Show("Дата виселення має бути пізніше дати заселення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Guest(lastName, firstName, passport, checkIn, checkOut, roomNumber);
        }

        private void CheckInLabel_Click(object sender, EventArgs e)
        {

        }
    }
}