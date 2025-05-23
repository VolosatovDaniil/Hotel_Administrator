using Hotel_Administrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Administrator.Forms
{
    public partial class EditRoomsForm : Form
    {
        private List<Room> rooms;

        public EditRoomsForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += EditRoomsForm_KeyDown;
            LoadRooms();
        }

        // Обробка клавіш: Enter - підтвердження, Esc - закриття, F1 - допомога
        private void EditRoomsForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                EditRoomsButton.PerformClick();
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
                    "Ви можете редагувати номер, клас і місткість номеру.\n" +
                    "Для прийняття змін, натисність кнопку 'Зберегти зміни'.",
                    "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        // Завантаження списку номерів із готелю до таблиці
        private void LoadRooms()
        {
            rooms = Hotel.Instance.Rooms;

            EditRoomsTable.Columns.Clear();
            EditRoomsTable.Rows.Clear();
            EditRoomsTable.AllowUserToAddRows = false;
            EditRoomsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EditRoomsTable.Columns.Add("Number", "Номер");
            EditRoomsTable.Columns.Add("Class", "Клас");
            EditRoomsTable.Columns.Add("Capacity", "Місткість");
            EditRoomsTable.Columns.Add("IsAvailable", "Доступність");

            foreach (var room in rooms)
            {
                EditRoomsTable.Rows.Add(
                    room.Number,
                    room.Class,
                    room.Capacity,
                    room.CurrentGuests.Count < room.Capacity ? "Доступний" : "Не доступний"
                );
            }
            EditRoomsTable.Columns["IsAvailable"].ReadOnly = true;
        }

        // Обробник натискання кнопки збереження змін
        private void EditRoomsButton_Click(object sender, EventArgs e)
        {
            var newRoomNumbers = new HashSet<int>();

            foreach (DataGridViewRow row in EditRoomsTable.Rows)
            {
                try
                {
                    if (row.IsNewRow) continue;

                    string numberText = row.Cells["Number"].Value?.ToString();
                    string classText = row.Cells["Class"].Value?.ToString();
                    string capacityText = row.Cells["Capacity"].Value?.ToString();

                    if (!int.TryParse(numberText, out int number) ||
                        !int.TryParse(capacityText, out int capacity) ||
                        string.IsNullOrWhiteSpace(classText))
                    {
                        throw new Exception("Некоректні або порожні дані!");
                    }

                    if (capacity <= 0)
                    {
                        throw new Exception(
                            $"Місткість у рядку {row.Index + 1} має бути більше 0!"
                        );
                    }

                    bool isDuplicate = rooms.Any(r => r.Number == number &&
                        EditRoomsTable.Rows[row.Index].Cells["Number"].Value.ToString() 
                        != r.Number.ToString());

                    if (newRoomNumbers.Contains(number) || isDuplicate)
                    {
                        throw new Exception(
                            $"Номер кімнати {number} не унікальний (рядок {row.Index + 1})."
                        );
                    }
                    newRoomNumbers.Add(number);

                    Room room = rooms.FirstOrDefault(r => r.Number == number);
                    if (room != null)
                    {
                        room.Class = classText;
                        room.Capacity = capacity;
                        room.IsAvailable = room.CurrentGuests.Count < room.Capacity;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Помилка в рядку {row.Index + 1}: {ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoadRooms();
            MessageBox.Show("Зміни збережено успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditRoomsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}