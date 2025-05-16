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
            foreach (DataGridViewRow row in EditRoomsTable.Rows)
            {
                try
                {
                    int number = Convert.ToInt32(row.Cells["Number"].Value);
                    string roomClass = row.Cells["Class"].Value.ToString();
                    int capacity = Convert.ToInt32(row.Cells["Capacity"].Value);

                    Room room = rooms.FirstOrDefault(r => r.Number == number);
                    if (room != null)
                    {
                        room.Class = roomClass;
                        room.Capacity = capacity;
                        room.IsAvailable = room.CurrentGuests.Count < room.Capacity;
                    }
                }
                catch
                {
                    MessageBox.Show("Помилка при збереженні. Перевірте введені дані!", "Помилка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoadRooms();
            MessageBox.Show("Зміни збережено!", "Успіх", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void EditRoomsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}