// 1. Объявление класса
public class Book
{
    // 2. Объявление свойств
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // 3. Объявление полей
    private string _note;
    private List<Book> _books;

    // 4. Создание конструктора
    public Book(int id, string author, string title, double price)
    {
        Id = id;
        Author = author;
        Title = title;
        Price = price;
    }

    // 5. Создание коллекции объектов через конструктор (без фигурных скобок)
    public List<Book> CreateBooks()
    {
        List<Book> books = new List<Book>();
        books.Add(new Book(1, "Л. Толстой", "Война и мир", 150));
        books.Add(new Book(2, "Дж. Оруэлл", "1984", 200));
        return books;
    }

    // 6. Создание коллекции объектов через конструктор (с фигурными скобками)
    public List<Book> CreateBooksInline()
    {
        List<Book> books = new List<Book>
        {
            new Book(1, "Л. Толстой", "Война и мир", 150),
            new Book(2, "Дж. Оруэлл", "1984", 200),
            new Book(3, "М. Булгаков", "Мастер и Маргарита", 180)
        };
        return books;
    }

    // 7. Создание коллекции объектов в методе
    public void ProcessBooks()
    {
        List<Book> localBooks = new List<Book>();
        localBooks.Add(new Book(1, "Книга", "Автор", 100));
    }

    // 8. Объявление метода
    public string GenerateGreeting()
    {
        return $"Привет, {Title}!";
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    // 9. Создание объекта класса
    public void Example()
    {
        Book book = new Book(1, "Иван", "Книга", 100);
        BookCatalog catalog = new BookCatalog();
    }

    // 10. Создание поля класса (List)
    private List<Book> _bookList = new List<Book>();

    // 11. Дополнительно: цикл foreach
    public void PrintBooks(List<Book> books)
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.Title);
        }
    }

    // 12. Дополнительно: условие if
    public void CheckAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Совершеннолетний");
        }
    }

    // 13. Дополнительно: try...catch
    public void ParseNumber(string input)
    {
        try
        {
            int number = int.Parse(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// Пример класса BookCatalog
public class BookCatalog
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return _books;
    }
}

// Лямбда-выражение
Book book = _books.FirstOrDefault(b => b.BookId == bookID);
// "В списке _books найди первую книгу, у которой BookId равен bookID, и сохрани её в переменной" 


// ШПАРГАЛКА ПО ОСНОВНЫМ ОПЕРАТОРАМ C#

// === 1. ОПЕРАТОРЫ СРАВНЕНИЯ ===
int x = 5;
int y = 10;

bool isEqual = x == y;      // Равно: false
bool isNotEqual = x != y;  // Не равно: true
bool isLess = x < y;        // Меньше: true
bool isGreater = x > y;     // Больше: false
bool lessOrEqual = x <= y;  // Меньше или равно: true
bool greaterOrEqual = x >= y; // Больше или равно: false


// === 2. ЛОГИЧЕСКИЕ ОПЕРАТОРЫ ===
bool a = true;
bool b = false;

bool notA = !a;             // Логическое НЕ: false
bool andAB = a && b;        // Условное И: false (не проверяет b, если a = false)
bool orAB = a || b;         // Условное ИЛИ: true (не проверяет b, если a = true)
bool bitwiseAnd = a & b;     // Логическое И: false (всегда проверяет оба)
bool bitwiseOr = a | b;      // Логическое ИЛИ: true (всегда проверяет оба)


// === 3. ОПЕРАТОРЫ ПРИСВАИВАНИЯ ===
int num = 10;               // Простое присваивание
num += 5;                   // Сложение с присваиванием: num = num + 5
num -= 3;                   // Вычитание с присваиванием: num = num - 3
num *= 2;                   // Умножение с присваиванием: num = num * 2
num /= 4;                   // Деление с присваиванием: num = num / 4
num %= 3;                   // Остаток с присваиванием: num = num % 3

// === 3.1. ЛОГИЧЕСКИЕ ОПЕРАТОРЫ С ПРИСВАИВАНИЕМ ===
bool flag = true;
flag &= true;               // Логическое И с присваиванием: flag = flag & true
flag &= false;              // flag = flag & false → результат: false

bool flag2 = true;
flag2 |= false;             // Логическое ИЛИ с присваиванием: flag2 = flag2 | false


// === 4. УСЛОВНЫЕ ОПЕРАТОРЫ ===
if (num > 0)
{
    Console.WriteLine("Число положительное");
}
else if (num < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число равно нулю");
}

// Switch-case
switch (num)
{
    case 1:
        Console.WriteLine("Один");
        break;
    case 2:
        Console.WriteLine("Два");
        break;
    default:
        Console.WriteLine("Другое число");
        break;
}


// === 5. ЦИКЛЫ ===
// For
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Цикл for: {i}");
}

// While
int counter = 0;
while (counter < 3)
{
    Console.WriteLine($"Цикл while: {counter}");
    counter++;
}

// Do-While
int counter2 = 0;
do
{
    Console.WriteLine($"Цикл do-while: {counter2}");
    counter2++;
} while (counter2 < 3);

// Foreach
int[] numbers = { 1, 2, 3 };
foreach (int number in numbers)
{
    Console.WriteLine($"Цикл foreach: {number}");
}


// === 6. ОБРАБОТКА ИСКЛЮЧЕНИЙ ===
try
{
    int result = 10 / 0; // Это вызовет ошибку
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Общая ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Этот блок выполнится всегда");
}


// === 7. ОПЕРАТОРЫ ТЕРНАРНЫЙ И NULL ===
string message = (num > 0) ? "Положительное" : "Не положительное"; // Тернарный оператор

string name = null;
string displayName = name ?? "Аноним"; // Оператор нулевого слияния


// === 8. ОПЕРАТОРЫ ИНКРЕМЕНТА И ДЕКРЕМЕНТА ===
int inc = 5;
int preIncrement = ++inc;    // Сначала увеличивает, потом возвращает: 6
int postIncrement = inc++;   // Сначала возвращает, потом увеличивает: 6 (inc = 7)

int dec = 5;
int preDecrement = --dec;    // Сначала уменьшает, потом возвращает: 4
int postDecrement = dec--;   // Сначала возвращает, потом уменьшает: 4 (dec = 3)


ДОбавить: словари, делегаты, наследование, миграции.
    Add-Migration InitialCreate
    Update-Database