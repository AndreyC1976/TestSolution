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


//ДОбавить: словари, делегаты, наследование, миграции.

// Миграции
    Add-Migration InitialCreate
    Update-Database


/*
 * СУТЬ КОНСТРУКЦИЙ ООП / ПАТТЕРНОВ
 * 
 * 1. НАСЛЕДОВАНИЕ (Inheritance)
 * 
 * Назначение:
 *   - Использование общих свойств и методов родительского класса.
 *   - Расширение функциональности базового класса.
 * 
 * Состав:
 *   - Класс-родитель (базовый класс) — содержит общую логику/состояние.
 *   - Классы-наследники — наследуют от родителя и могут переопределять/добавлять поведение.
 * 
 * Метод выбора:
 *   - Выбор реализации происходит через тип объекта (наследника) при вызове виртуального/абстрактного метода.
 *   - Вызывающий код работает с объектом через тип родителя, но выполняется метод наследника (полиморфизм).
 * 
 * Пример:
 */
public abstract class Shape
{
    public string Color { get; set; } = "Белый";
    public abstract double CalculateArea(); // Абстрактный метод - наследники обязаны реализовать
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

// Использование:
// Shape shape = new Rectangle { Color = "Красный", Width = 5, Height = 3 };
// double area = shape.CalculateArea(); // Вызовет Rectangle.CalculateArea()


/*
 * 2. ДЕЛЕГАТЫ (Delegates)
 * 
 * Назначение:
 *   - Хранение ссылки на метод и возможность вызвать его позже.
 *   - Выбор метода для выполнения на основе данных (например, из словаря).
 * 
 * Состав:
 *   - Объявление делегата (определяет "вилку" — сигнатуру метода).
 *   - Словарь или список для сопоставления ключа с делегатом (по желанию).
 *   - Методы, соответствующие сигнатуре делегата.
 * 
 * Выбор:
 *   - Выбор метода осуществляется через переменную типа делегат.
 *   - Значение (ссылка на метод) можно получить, например, из словаря по ключу.
 * 
 * Пример:
 */
public delegate string MessageMethod(); // "Вилка" для методов: () -> string

public class MessageService
{
    public string SayHello() => "Привет!";
    public string SayGoodbye() => "Пока!";
}

// Использование:
// var messageMethods = new Dictionary<string, MessageMethod>
// {
//     { "1", service.SayHello },
//     { "2", service.SayGoodbye }
// };
// if (messageMethods.TryGetValue(input, out MessageMethod selectedMethod))
// {
//     string result = selectedMethod(); // Вызов делегата
// }


/*
 * 3. ИНТЕРФЕЙСЫ (Interfaces)
 * 
 * Назначение:
 *   - Определение контракта (обязательного поведения) для классов.
 *   - Гибкий способ полиморфизма (один класс может реализовать несколько интерфейсов).
 *   - Возможность подмены реализаций (например, для тестирования).
 * 
 * Состав:
 *   - Объявление интерфейса — список методов/свойств, которые должен реализовать класс.
 *   - Классы, реализующие интерфейс — обязаны предоставить тела для всех членов интерфейса.
 * 
 * Выбор:
 *   - Выбор реализации происходит через передачу объекта конкретного класса,
 *     реализующего интерфейс, в метод, который принимает интерфейс.
 * 
 * Пример:
 */
public interface IOperation
{
    double Execute(double first, double second); // Контракт: метод должен быть реализован
}

public class Addition : IOperation
{
    public double Execute(double first, double second) => first + second;
}

public class Calculator
{
    public double Calculate(double a, double b, IOperation operation) // Принимает "вилку"
    {
        return operation.Execute(a, b); // Вызов через интерфейс -> выполнится в конкретной реализации
    }
}

// Использование:
// Calculator calc = new Calculator();
// IOperation op = new Addition(); // Объект Addition, переменная типа IOperation
// double result = calc.Calculate(5, 3, op); // Вызовет Addition.Execute()

/*
 * ПАТТЕРНЫ ПРОЕКТИРОВАНИЯ
 * 
 * 1. ПАТТЕРН "СТРАТЕГИЯ" (Strategy Pattern)
 * 
 * Назначение:
 *   - Позволяет выбирать алгоритм (поведение) во время выполнения.
 *   - Изолирует различные реализации одного действия.
 * 
 * Состав:
 *   - Интерфейс/абстрактный класс для стратегии (например, IOperation).
 *   - Классы, реализующие интерфейс/наследующие абстрактный класс (например, Addition, Multiplication).
 *   - Контекст, который использует стратегию (например, Calculator).
 * 
 * Выбор:
 *   - Выбор конкретной стратегии происходит через передачу объекта стратегии в контекст.
 * 
 * Пример:
 */
public interface IOperation // Интерфейс стратегии
{
    double Execute(double first, double second);
}

public class Addition : IOperation // Конкретная стратегия
{
    public double Execute(double first, double second) => first + second;
}

public class Multiplication : IOperation // Конкретная стратегия
{
    public double Execute(double first, double second) => first * second;
}

public class Calculator // Контекст
{
    private IOperation _operation; // Поле для хранения текущей стратегии

    public void SetOperation(IOperation operation) // Метод для смены стратегии
    {
        _operation = operation;
    }

    public double Calculate(double a, double b)
    {
        if (_operation == null) throw new InvalidOperationException("Стратегия не установлена.");
        return _operation.Execute(a, b); // Вызов метода текущей стратегии
    }
}

// Использование:
// Calculator calc = new Calculator();
// calc.SetOperation(new Addition()); // Установили стратегию сложения
// double result = calc.Calculate(5, 3); // Вызовет Addition.Execute() -> 8
// calc.SetOperation(new Multiplication()); // Сменили стратегию
// result = calc.Calculate(5, 3); // Вызовет Multiplication.Execute() -> 15


/*
 * 2. ПАТТЕРН "ФАБРИКА" (Factory Pattern)
 * 
 * Назначение:
 *   - Инкапсулирует создание объектов.
 *   - Позволяет делегировать создание объектов другому классу.
 * 
 * Состав:
 *   - Класс-фабрика, который содержит логику создания объектов.
 *   - Обычно возвращает объекты через интерфейс или базовый класс.
 * 
 * Выбор:
 *   - Выбор, какой класс создать, происходит внутри фабрики, часто на основе параметра.
 * 
 * Пример:
 */
public class OperationFactory // Класс-фабрика
{
    public IOperation CreateOperation(string operationType) // Метод фабрики
    {
        return operationType.ToLower() switch
        {
            "add" => new Addition(),
            "multiply" => new Multiplication(),
            // ... другие операции
            _ => throw new ArgumentException($"Неизвестный тип операции: {operationType}")
        };
    }
}

// Использование:
// OperationFactory factory = new OperationFactory();
// IOperation op = factory.CreateOperation("add"); // Фабрика создаёт Addition
// double result = op.Execute(5, 3); // Вызовет Addition.Execute() -> 8


/*
 * 3. ПАТТЕРН "НАБЛЮДАТЕЛЬ" (Observer Pattern)
 * 
 * Назначение:
 *   - Определяет зависимость "один ко многим" между объектами.
 *   - Когда изменяется состояние одного объекта, все зависящие от него объекты уведомляются и обновляются автоматически.
 * 
 * Состав:
 *   - Субъект (Subject) — объект, за которым наблюдают. Он управляет списком наблюдателей.
 *   - Наблюдатель (Observer) — интерфейс/абстрактный класс для объектов, которые хотят получать уведомления.
 *   - Конкретные наблюдатели — реализуют интерфейс наблюдателя.
 * 
 * Выбор:
 *   - Наблюдатели "подписываются" на субъект. Субъект "уведомляет" всех подписчиков при изменении.
 * 
 * Пример:
 */
using System.Collections.Generic;

public interface IObserver // Интерфейс наблюдателя
{
    void Update(string message); // Метод, который вызывается при уведомлении
}

public class NewsAgency // Субъект
{
    private List<IObserver> _observers = new List<IObserver>(); // Список наблюдателей

    public void Subscribe(IObserver observer) // Подписка
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer) // Отписка
    {
        _observers.Remove(observer);
    }

    public void Notify(string news) // Уведомление всех наблюдателей
    {
        foreach (var observer in _observers)
        {
            observer.Update(news);
        }
    }

    // Метод, который меняет состояние и вызывает уведомление
    public void AddNews(string news)
    {
        Notify(news); // Уведомляем всех
    }
}

public class NewsChannel : IObserver // Конкретный наблюдатель
{
    public string Name { get; set; }

    public NewsChannel(string name)
    {
        Name = name;
    }

    public void Update(string message) // Реализация метода уведомления
    {
        Console.WriteLine($"{Name} получил новости: {message}");
    }
}

// Использование:
// NewsAgency agency = new NewsAgency();
// NewsChannel channel1 = new NewsChannel("Канал 1");
// NewsChannel channel2 = new NewsChannel("Канал 2");
// 
// agency.Subscribe(channel1); // Подписываем наблюдателей
// agency.Subscribe(channel2);
// 
// agency.AddNews("Новый паттерн проектирования!"); // Уведомит channel1 и channel2


/*
 * ШПАРГАЛКА: СЛОВАРИ (DICTIONARY)
 * 
 * Словарь — это коллекция, которая хранит пары "ключ-значение".
 * Позволяет быстро находить значение по ключу.
 * 
 * 1. ПРОСТОЙ СЛОВАРЬ КЛЮЧ-ЗНАЧЕНИЕ
 * 
 * Назначение:
 *   - Хранение соответствия между уникальным ключом и каким-то значением.
 *   - Быстрый поиск значения по ключу (вместо множества `if` или `switch`).
 * 
 * Состав:
 *   - `Dictionary<TKey, TValue>` — сам класс словаря.
 *   - `TKey` — тип ключа (например, string, int).
 *   - `TValue` — тип значения (например, string, int, object).
 *   - Инициализация словаря и заполнение парами `{ ключ, значение }`.
 * 
 * Пример:
 */
using System;
using System.Collections.Generic;

// Объявляем словарь: ключ - строка (например, имя месяца), значение - строка (например, пора года)
var seasons = new Dictionary<string, string>
{
    { "Январь", "Зима" },
    { "Февраль", "Зима" },
    { "Март", "Весна" },
    { "Апрель", "Весна" },
    { "Май", "Весна" },
    // ... и так далее
};

// Проверяем, есть ли ключ в словаре и получаем значение
if (seasons.TryGetValue("Март", out string seasonValue))
{
    Console.WriteLine($"Март - это {seasonValue}"); // Выведет: Март - это Весна
}
else
{
    Console.WriteLine("Месяц не найден в словаре.");
}

/*
 * 2. СЛОВАРЬ СО ЗНАЧЕНИЕМ-КОРТЕЖЕМ, ГДЕ ОДИН ИЗ ЭЛЕМЕНТОВ - ВЫЗЫВАЕМЫЙ МЕТОД
 * 
 * Назначение:
 *   - Хранение не только данных, но и действия (метода), связанного с ключом.
 *   - Позволяет выбрать и выполнить нужный метод на основе ключа, опять же избегая `if`/`switch`.
 * 
 * Состав:
 *   - `Dictionary<TKey, (TData, Action)>` — словарь, где значение — это кортеж.
 *   - `TKey` — тип ключа.
 *   - `(TData, Action)` — кортеж, первый элемент - какая-то информация (например, строка), второй - делегат (Action, Func и т.п.).
 *   - Делегат (Action) — это "вилка" для метода, который можно вызвать.
 *   - Инициализация словаря с анонимными методами или ссылками на методы.
 * 
 * Пример:
 */

// 1. Объявляем делегат (вилку) для методов, которые не принимают параметров и ничего не возвращают
public delegate void CommandAction();

// Или используем встроенный делегат Action
// public static void Main()
// {
// Объявляем словарь: ключ - строка (например, команда), значение - кортеж (описание, метод)
var commandMap = new Dictionary<string, (string Description, Action Action)>
    {
        { "hello", ("Приветствие", () => Console.WriteLine("Привет, мир!")) },
        { "time", ("Показать время", () => Console.WriteLine($"Текущее время: {DateTime.Now}")) },
        { "exit", ("Выйти", () => Environment.Exit(0)) }
    };

// Пользователь вводит команду
Console.Write("Введите команду (hello, time, exit): ");
string userCommand = Console.ReadLine();

// Ищем команду в словаре
if (commandMap.TryGetValue(userCommand, out var commandTuple))
{
    // Получили кортеж (Description, Action)
    string description = commandTuple.Description;
    Action actionToExecute = commandTuple.Action; // <-- Это делегат, ссылка на метод

    Console.WriteLine($"Выполняется команда: {description}");
    actionToExecute(); // <-- Вызываем метод через делегат
}
else
{
    Console.WriteLine("Неизвестная команда.");
}
// }