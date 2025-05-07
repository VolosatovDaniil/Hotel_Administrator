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
            LoadRooms();
        }

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
            // Заборона редагування стовпця доступності
            EditRoomsTable.Columns["IsAvailable"].ReadOnly = true;
        }

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
                    MessageBox.Show("Помилка при збереженні. Перевірте введені дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoadRooms();
            MessageBox.Show("Зміни збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditRoomsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}