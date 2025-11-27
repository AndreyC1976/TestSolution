using Books;
using System.Data.Common;
using static System.Reflection.Metadata.BlobBuilder;



//Инициализируем создание списка книг: из кода или файла
BookFileService fileService = new();
BookCatalog catalog = new();
UserDialog dialog = new();
bool toExit = catalog.InitializeBooks(fileService, dialog);
if (!toExit) {return;} //Прекращение выполнения программы


//Добавляем новую книгу в существующий список
Book newBook = new Book(5, "А. Пушкин", "Евгений Онегин", 120); 
catalog.AddBook(newBook);

//Устанавливаем цены
catalog.ChangePrice(3, 15);

//Выводим сформированный список книг
Console.Clear();
Console.WriteLine("\x1b[1mСформированный писок книг:\x1b[0m");
foreach (Book book in catalog.GetBooks())
{
    Console.WriteLine($"{book.BookId}. {book.Title} ({book.Author}) — Цена: {book.Price} руб., кол-во {book.InStock} шт.");
}

//Оформляем поступление
StockManagement stock = new();
stock.BooksIncome(catalog, dialog);

//Оформляем продажу книг
stock.BooksSell(catalog, dialog);

//Подсчитываем выручку
double totalRevenue = catalog.CalculateRevenue(catalog);


//Сохраняем в файл
//BookFileService fileService = new BookFileService();
fileService.SaveToFile(catalog.GetBooks(), "books_Save_To.txt");


//Выводим измененный список книг
Console.WriteLine();
Console.WriteLine("\x1b[1mИзмененный писок книг:\x1b[0m");
foreach (Book book in catalog.GetBooks())
{
    Console.WriteLine($"{book.BookId}. {book.Title} ({book.Author}) — Цена: {book.Price} руб., кол-во {book.InStock} шт., " +
        $"выручка: {book.Revenue}");
}
Console.WriteLine();
Console.WriteLine($"Полная выручка за все книги: { totalRevenue }");

//Завершение консоли
Console.WriteLine();
Console.WriteLine("Выполнение программы завершено. Нажмите любую клавишу для выхода.");
Console.ReadKey();
