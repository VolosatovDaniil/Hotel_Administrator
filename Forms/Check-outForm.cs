using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Hotel_Administrator.Models;

namespace Hotel_Administrator.Forms
{
    public partial class CheckOutForm : Form
    {
        // Гість, якого буде виселено
        public Guest GuestToCheckOut { get; private set; }

        public string PassportId => GuestToCheckOut?.PassportId ?? PassportTextBox.Text;

        public CheckOutForm()
        {
            InitializeComponent();
            CheckOutDatePicker.Value = DateTime.Today;

            this.KeyPreview = true;
            this.KeyDown += CheckOutForm_KeyDown;
        }

        // Обробка клавіш: Enter - підтвердження, Esc - закриття, F1 - допомога
        private void CheckOutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmCheckOutButton.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(
                    "Щоб виселити гостя, заповніть усі поля та " +
                    "натисніть кнопку 'Підтвердити виселення'.",
                    "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        // Форма виселення з автозаповненням
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

        // Обробник натискання кнопки підтвердження виселення
        private void ConfirmCheckOutButton_Click(object sender, EventArgs e)
        {
            if (GuestToCheckOut == null)
            {
                string passport = PassportTextBox.Text.Trim();
                GuestToCheckOut = Hotel.Instance.Guests
                    .FirstOrDefault(g => g.PassportId == passport);

                if (GuestToCheckOut == null)
                {
                    MessageBox.Show("Гість з таким паспортом не знайдений.", "Помилка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Оновлення дати виїзду
            GuestToCheckOut.CheckOutDate = CheckOutDatePicker.Value;

            // Обчислення суми
            decimal totalAmount = Hotel.Instance.CalculateCharge(GuestToCheckOut);

            // Створення квитанції
            var receipt = new Receipt(
                Hotel.Instance.GenerateReceiptId(),
                GuestToCheckOut.PassportId,
                GuestToCheckOut.CheckOutDate,
                totalAmount,
                ReceiptType.CheckOut
            );

            Hotel.Instance.Receipts.Add(receipt);
            Hotel.Instance.Guests.Remove(GuestToCheckOut);

            var room = Hotel.Instance.Rooms
                .FirstOrDefault(r => r.Number == GuestToCheckOut.RoomNumber);
            room?.CurrentGuests.Remove(GuestToCheckOut);

            // Збереження квитанції у текстовий файл
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Зберегти квитанцію";
                saveDialog.Filter = "Текстові файли (*.txt)|*.txt";
                saveDialog.FileName = $"CheckOut_{GuestToCheckOut.PassportId}_{receipt.Id}.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string path = saveDialog.FileName;

                        string content =
                            $"Квитанція №{receipt.Id}\r\n" +
                            $"Тип: {receipt.Type}\r\n" +
                            $"ПІБ: {GuestToCheckOut.LastName} {GuestToCheckOut.FirstName}\r\n" +
                            $"Паспорт: {GuestToCheckOut.PassportId}\r\n" +
                            $"Номер кімнати: {GuestToCheckOut.RoomNumber}\r\n" +
                            $"Дата заселення: {GuestToCheckOut.CheckInDate:dd.MM.yyyy}\r\n" +
                            $"Дата виселення: {GuestToCheckOut.CheckOutDate:dd.MM.yyyy}\r\n" +
                            $"Сума до сплати: {receipt.Amount} грн\r\n" +
                            $"Дата створення квитанції: {receipt.Date:dd.MM.yyyy}";

                        File.WriteAllText(path, content);
                        MessageBox.Show("Квитанцію збережено успішно!", "Успіх", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні квитанції: " + ex.Message, 
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}