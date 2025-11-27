using Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public double Revenue { get; set; }

        // Конструктор с параметрами без количества
        public Book(int bookId, string author, string title, double price)
        {
            BookId = bookId;
            Author = author;
            Title = title;
            Price = price;
        }

        // Конструктор с параметрами с количеством
        public Book(int bookId, string author, string title, double price, int inStock)
        {
            BookId = bookId;
            Author = author;
            Title = title;
            Price = price;
            InStock = inStock;
        }

        // Конструктор по умолчанию, для создания пустого объекта в другом классе
        public Book() { }


        //public double GetRevenue()
        //{
        //    return Price * InStock;
        //}
    }
}