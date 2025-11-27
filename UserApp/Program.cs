// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UserApp;

class Program
{
    static void Main()
    {
        Console.Write("Введите имя:");
        String name = Console.ReadLine();
        
        Console.Write("Введите возраст:");
        int age = int.Parse(Console.ReadLine());
        
        User user = new User(name, age);


        Console.WriteLine(user.GenerateGreeting());
        Console.WriteLine(user.IsAdult());
    }
}

