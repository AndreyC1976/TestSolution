using TestBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestBooks
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        // Конструктор с параметрами без количества
        public Book(int bookId, string author, string title, double price)
        {
            BookId = bookId;
            Author = author;
            Title = title;
            Price = price;
        }
        
        // Конструктор с параметрами с количеством
        public Book(int bookId, string author, string title, double price, int quantity)
        {
            BookId = bookId;
            Author = author;
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        // Конструктор по умолчанию, для создания пустого объекта в другом классе
        public Book() { }

        public double GetRevenue()
        {
            return Price * Quantity;
        }
    }
}
