using System.Collections.Generic;

namespace Hotel_Administrator.Models
{
    /// Клас представляє готельний номер з певною кількістю місць, класом та списком гостей.
    public class Room
    {
        // Номер кімнати (ідентифікатор)
        public int Number { get; set; }

        // Клас кімнати ("Економ", "Стандарт", "Люкс")
        public string Class { get; set; }

        // Максимальна кількість гостей, яких можна розмістити
        public int Capacity { get; set; }

        // Показує, чи номер доступний для поселення
        public bool IsAvailable { get; set; }

        // Список гостей, які зараз проживають у номері
        public List<Guest> CurrentGuests { get; set; } = new List<Guest>();

        // Конструктор для ініціалізації нового номера
        public Room(int number, string roomClass, int capacity)
        {
            Number = number;
            Class = roomClass;
            Capacity = capacity;
            IsAvailable = true;
        }
    }
}