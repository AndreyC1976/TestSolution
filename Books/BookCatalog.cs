using Books;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BookCatalog
    {
        public List<Book> _books = new();
        public bool InitializeBooks(BookFileService fileService, UserDialog dialog)
        {
            //UserDialog dialog = new();
            string userChoice = dialog.UserChoiceLoad();

            do
            {
                bool success = true;
                if (userChoice == "1")
                {
                    InitializeFromMemory();
                    return true;
                }
                else if (userChoice == "2")
                {
                    success = fileService.LoadFromFile("books_To_load.txt", this);
                    if (!success)
                    {
                        userChoice = dialog.UserChoiceLoad();
                        continue;
                    }
                    return true;
                }
                else if (userChoice == "0")
                {
                    return false;
                }
            } while (true);
            
        } // Окончание public void InitializeBooks()

        private void InitializeFromMemory()
        {
            _books.Clear();
            _books.AddRange(new List<Book>
            {
            new Book(1, "Л. Толстой", "Война и мир", 150),
            new Book(2, "Дж. Оруэлл", "1984", 200),
            new Book(3, "М. Булгаков", "Мастер и Маргарита", 180)
            });
        }  // Окончание private void InitializeFromMemory()

        public List<Book> GetBooks()
            {
                return _books;
            }

        public void AddBook(Book newBook) // Метод добавление книги
        {
            _books.Add(newBook);
        }

        public void ClearBooks()
        { 
            _books.Clear(); 
        }

        public void ChangePrice(int bookID, int price)
        {
            Book book = _books.FirstOrDefault(b => b.BookId == bookID);

            if (book != null)
            {
                book.InStock += price;
            }
        }

        public void BookQuantityAdd (int bookID, int amountChange)
        {
            Book book = _books.FirstOrDefault(b => b.BookId == bookID);

            if (book != null)
            {
                book.InStock += amountChange;
            }
        }
        public double BookQuantityRemove(int bookID, int amountChange)
        {
            Book book = _books.FirstOrDefault(b => b.BookId == bookID);

            double amountDifference = book.InStock - amountChange;

            if (book != null && amountDifference >= 0)
            {
                book.InStock = book.InStock - amountChange;
                return amountDifference;
            }
            else 
            {
                 return amountDifference;
            }
        } // Окончание метода BookQuantityRemove


        public double CalculateRevenue(BookCatalog catalog)
        {
            double totalRevenue = 0;
            foreach  (Book bookRevenue in _books)
            {
                bookRevenue.Revenue = bookRevenue.Price * bookRevenue.InStock;
                totalRevenue += bookRevenue.Revenue;
            }

            return totalRevenue;
        } // Окончание метода CalculateRevenue

    } // Окончание класса BookCatalog
}  // Окончание namespace Books 
