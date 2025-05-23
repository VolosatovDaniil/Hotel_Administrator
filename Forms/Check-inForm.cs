using System;
using System.Windows.Forms;
using Hotel_Administrator.Models;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Hotel_Administrator.Forms
{
    public partial class Check_inForm : Form
    {
        // Гість, створений у результаті заповнення форми
        public Guest CreatedGuest { get; private set; }

        public Check_inForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Check_inForm_KeyDown;
        }

        // Обробка клавіш: Enter - підтвердження, Esc - закриття, F1 - допомога
        private void Check_inForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmCheckInButton.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(
                    "Щоб заселити гостя, заповніть усі поля та натисніть кнопку 'Підтвердити'.",
                    "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        // Обробник натискання кнопки підтвердження заселення
        private void ConfirmCheckInButton_Click(object sender, EventArgs e)
        {
            Guest guest = GetGuestIfValid();
            if (guest != null)
            {
                Hotel.Instance.Guests.Add(guest);
                CreatedGuest = guest;

                int receiptId = Hotel.Instance.Receipts.Any() 
                    ? Hotel.Instance.Receipts.Max(r => r.Id) + 1 
                    : 1;
                var receipt = new Receipt(receiptId, guest.PassportId, DateTime.Now, 
                    0, ReceiptType.CheckIn);
                Hotel.Instance.Receipts.Add(receipt);

                SaveReceiptToFile(receipt, guest);
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
                MessageBox.Show("Усі поля мають бути заповнені!", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!int.TryParse(roomText, out int roomNumber))
            {
                MessageBox.Show("Номер кімнати має бути числом!", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (checkIn >= checkOut)
            {
                MessageBox.Show("Дата виселення має бути пізніше дати заселення!", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new Guest(lastName, firstName, passport, checkIn, checkOut, roomNumber);
        }

        // Збереження квитанції у текстовий файл
        private void SaveReceiptToFile(Receipt receipt, Guest guest)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt",
                Title = "Зберегти квитанцію про заселення",
                FileName = $"CheckIn_{guest.PassportId}_{receipt.Id}.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName,
$@"Квитанція №{receipt.Id}
Тип: {receipt.Type}
ПІБ: {guest.FullName}
Паспорт: {guest.PassportId}
Номер кімнати: {guest.RoomNumber}
Дата заселення: {guest.CheckInDate:dd.MM.yyyy}
Дата виселення: {guest.CheckOutDate:dd.MM.yyyy}
Дата створення квитанції: {receipt.Date:dd.MM.yyyy}");
            }
        }

        // Обробник кнопки завантаження гостей із CSV-файлу
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV файли (*.csv)|*.csv",
                Title = "Оберіть CSV-файл із гостями"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    int successCount = 0, errorCount = 0;

                    foreach (string line in lines.Skip(1))
                    {
                        string[] parts = line.Split(new[] { ';', ',' }, StringSplitOptions.None);

                        if (parts.Length != 6) { errorCount++; continue; }

                        string lastName = parts[0].Trim();
                        string firstName = parts[1].Trim();
                        string passport = parts[2].Trim();
                        string checkInStr = parts[3].Trim();
                        string checkOutStr = parts[4].Trim();
                        string roomStr = parts[5].Trim();

                        if (!DateTime.TryParse(checkInStr, out DateTime checkIn) ||
                            !DateTime.TryParse(checkOutStr, out DateTime checkOut) ||
                            !int.TryParse(roomStr, out int roomNumber) ||
                            checkIn >= checkOut ||
                            string.IsNullOrWhiteSpace(lastName) ||
                            string.IsNullOrWhiteSpace(firstName) ||
                            string.IsNullOrWhiteSpace(passport))
                        {
                            errorCount++;
                            continue;
                        }

                        Guest guest = new Guest(lastName, firstName, passport, checkIn, 
                            checkOut, roomNumber);
                        Hotel.Instance.Guests.Add(guest);

                        int receiptId = Hotel.Instance.Receipts.Any() 
                            ? Hotel.Instance.Receipts.Max(r => r.Id) + 1 
                            : 1;
                        var receipt = new Receipt(receiptId, guest.PassportId, DateTime.Now, 
                            0, ReceiptType.CheckIn);
                        Hotel.Instance.Receipts.Add(receipt);

                        SaveReceiptToFile(receipt, guest);
                        successCount++;
                    }
                    MessageBox.Show(
                        $"Успішно додано: {successCount} гостей.\n" +
                        $"Пропущено помилкових рядків: {errorCount}.",
                        "Імпорт завершено", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при зчитуванні файлу: " + ex.Message, 
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckInLabel_Click(object sender, EventArgs e) { }
    }
}