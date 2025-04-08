using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Administrator.Models
{
    namespace Hotel_Administrator.Models
    {
        /// Фасадний клас, який містить основну логіку управління готелем, номерами, гостями та квитанціями.
        public class Hotel
        {
            /// Список всіх номерів у готелі
            public List<Room> Rooms { get; set; } = new List<Room>();

            /// Список всіх гостей готелю
            public List<Guest> Guests { get; set; } = new List<Guest>();

            /// Список усіх квитанцій
            public List<Receipt> Receipts { get; set; } = new List<Receipt>();

            /// Ініціалізує готель із тестовими даними
            public Hotel()
            {
                // Створення номерів
                Rooms.Add(new Room(101, "Економ", 2));
                Rooms.Add(new Room(102, "Стандарт", 3));
                Rooms.Add(new Room(201, "Люкс", 2));

                // Створення гостей
                Guests.Add(new Guest("Шевченко", "Олександр", "AB123456", new DateTime(2025, 4, 1), new DateTime(2025, 4, 8), 101));
                Guests.Add(new Guest("Мельник", "Ганна", "CD123456", new DateTime(2025, 4, 2), new DateTime(2025, 4, 10), 102));

                // Додати гостей до номерів
                Rooms[0].CurrentGuests.Add(Guests[0]);
                Rooms[1].CurrentGuests.Add(Guests[1]);

                // Створення квитанцій
                Receipts.Add(new Receipt(1, "AB123456", new DateTime(2025, 4, 1), 7000, ReceiptType.CheckIn));
                Receipts.Add(new Receipt(2, "CD654321", new DateTime(2025, 4, 2), 8000, ReceiptType.CheckIn));
            }

            /// Пошук гостей за частковим збігом імені, прізвища або паспорта
            public List<Guest> SearchGuests(string searchTerm)
            {
                if (string.IsNullOrWhiteSpace(searchTerm)) return new List<Guest>();

                searchTerm = searchTerm.ToLower();
                return Guests
                    .Where(g =>
                        (!string.IsNullOrEmpty(g.FirstName) && g.FirstName.ToLower().Contains(searchTerm)) ||
                        (!string.IsNullOrEmpty(g.LastName) && g.LastName.ToLower().Contains(searchTerm)) ||
                        (!string.IsNullOrEmpty(g.PassportId) && g.PassportId.ToLower().Contains(searchTerm)))
                    .ToList();
            }

            /// Пошук номера за номером кімнати або класом
            public List<Room> SearchRooms(string searchTerm)
            {
                if (string.IsNullOrWhiteSpace(searchTerm)) return new List<Room>();

                searchTerm = searchTerm.ToLower();
                return Rooms
                    .Where(r =>
                        r.Number.ToString().Contains(searchTerm) ||
                        (!string.IsNullOrEmpty(r.Class) && r.Class.ToLower().Contains(searchTerm)))
                    .ToList();
            }

            /// Повертає список гостей, які повинні виїхати сьогодні
            public List<Guest> GetGuestsCheckingOutToday()
            {
                DateTime today = DateTime.Today;
                return Guests
                    .Where(g => g.CheckOutDate.Date == today)
                    .ToList();
            }
        }
    }
}