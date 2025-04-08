using System;

namespace Hotel_Administrator.Models
{
    /// Клас представляє квитанцію на оплату, пов’язану з гостем готелю
    public class Receipt
    {
        /// Унікальний ідентифікатор квитанції
        public int Id { get; set; }

        /// Паспортний номер гостя, до якого належить квитанція
        public string GuestPassportId { get; set; }

        /// Дата створення квитанції
        public DateTime Date { get; set; }

        /// Сума, зазначена в квитанції
        public decimal Amount { get; set; }

        /// Тип квитанції (заселення або виїзд)
        public ReceiptType Type { get; set; }

        /// Конструктор для ініціалізації нової квитанції
        public Receipt(int id, string guestPassportId, DateTime date, decimal amount, ReceiptType type)
        {
            Id = id;
            GuestPassportId = guestPassportId;
            Date = date;
            Amount = amount;
            Type = type;
        }
    }

    /// Перелік можливих типів квитанції
    public enum ReceiptType
    {
        CheckIn,
        CheckOut
    }
}
