using System;

namespace Hotel_Administrator.Models
{
    /// Клас представляє гостя готелю з паспортними даними, прізвищем, ім’ям, датами приїзду/виїзду та номером кімнати
    public class Guest
    {
        /// Паспортний номер гостя
        public string PassportId { get; set; }

        /// Прізвище гостя
        public string LastName { get; set; }

        /// Ім’я гостя
        public string FirstName { get; set; }

        /// Повне ім’я гостя (Прізвище + Ім’я)
        public string FullName => $"{LastName} {FirstName}";

        /// Дата заселення гостя
        public DateTime CheckInDate { get; set; }

        /// Дата виїзду гостя
        public DateTime CheckOutDate { get; set; }

        /// Номер кімнати, у якій проживає гість
        public int RoomNumber { get; set; }

        /// Конструктор для ініціалізації нового гостя
        public Guest(string lastName, string firstName, string passportId, DateTime checkIn, DateTime checkOut, int roomNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            PassportId = passportId;
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
            RoomNumber = roomNumber;
        }
    }
}