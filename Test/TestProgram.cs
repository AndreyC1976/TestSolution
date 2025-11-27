using TestBooks;
bool isValid = false;

do
{
    Console.WriteLine("Загрузить книги из памяти (1) или из файла (2)?");
    string choice = Console.ReadLine();

    if (choice == "1" || choice == "2")
    {
        isValid = true;

        if (choice == "1")
        {
            Console.WriteLine("Загружаем из памяти");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Загружаем из файла");
        }
    }
    else
    {
        Console.WriteLine("Неверное значение");
        isValid = false;
    }

} while (!isValid);











//List<string[]> allParts = new List<string[]>();
//List<Book> books = new List<Book>();

//string[] lines = File.ReadAllLines("books2.txt");

//foreach (string line in lines)
//{
//    string[] parts = line.Split(';');
//    allParts.Add(parts);

//    if (parts.Length == 5)
//        {
//            Book book = new Book(
//                int.Parse(parts[0]), 
//                parts[1], 
//                parts[2], 
//                int.Parse(parts[3]), 
//                int.Parse(parts[4]));
//            books.Add(book);
//        }
//}

//foreach (Book book in books)
//{ 
//Console.WriteLine($"{book.BookId}. {book.Author} {book.Title}");

//}




//                Book book = new Book(
//                    int.Parse(parts[0]),   // Id
//                    parts[1],              // Author
//                    parts[2],              // Title
//                    double.Parse(parts[3]), // Price
//                    int.Parse(parts[4])    // Quantity
//                );


//foreach (string line in lines)
//{
//    string[] parts = line.Split(';');
//    allParts.Add(parts);

//    foreach (string part in parts)
//    {
//        //Console.WriteLine(part);
//    }
//    //Console.WriteLine($"---------------{parts.Length}");
//}
//Console.WriteLine(allParts[0][1]);