using Books;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BookFileService
    {
        public void SaveToFile(List<Book> books, string filename)
        {
            try
            { 
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Book book in books)
                    {
                        writer.WriteLine($"{book.BookId};{book.Author};{book.Title};{book.Price};{book.InStock}");
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Неудачная попытка записи в файл. Программа вернула ошибку: { ex.Message}");
            }
        }
        public bool LoadFromFile(string filename, BookCatalog catalog)
        {
            catalog.ClearBooks();

            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не найден");
                return false;
            }
            
            string[] lines = File.ReadAllLines(filename);

            try
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        Book book = new(
                            int.Parse(parts[0]),
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            int.Parse(parts[4]));

                        catalog.AddBook(book);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неверный формат файла. Программа вернула ошибку: {ex.Message}");
                return false;
            }
        }
    }
}
