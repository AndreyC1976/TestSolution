using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Books;

namespace Books
{
    
    public class UserDialog
    {
        
        public string UserChoiceLoad()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Загрузить книги из памяти (1) или из файла (2)? Для выхода выбирте (0)");
                string choiceLoad = Console.ReadLine();
                bool success = true;

                if (choiceLoad == "1" || choiceLoad == "2" || choiceLoad == "0")
                {
                    isValid = true;

                    if (choiceLoad == "1")
                    {
                        Console.WriteLine("Загружаем из памяти");
                        return choiceLoad;
                    }
                    else if (choiceLoad == "2")
                    {
                        Console.WriteLine("Загружаем из файла");
                        return choiceLoad;
                    }
                    else if (choiceLoad == "0")
                    {
                        Console.WriteLine("Выполнение программы прекращено");
                                                return choiceLoad;
                    }
                }
                else
                {
                    Console.WriteLine("Выбран несуществующий вариант загрузки списка книг.");
                    isValid = false;
                }

                if (!success)
                {
                    isValid = false;
                }
                return choiceLoad;
            } while (!isValid);
        } // Окончание метода UserChoice

        public string UserChoiceIncome()
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Требуется ли оформить приход книг? Если да, нажмите (1), если нет - (0)");
                string choiceIncome = Console.ReadLine();

                if (choiceIncome == "1" || choiceIncome == "0")
                {
                    return choiceIncome;
                }
                else { continue; }
            } while (true);
        }// Окончание класса UserChoiceIncome

        public string UserChoiceSell()
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Требуется ли продать книги? Если да, нажмите (1), если нет - (0)");
                string choiceSell = Console.ReadLine();

                if (choiceSell == "1" || choiceSell == "0")
                {
                    return choiceSell;
                }
                else { continue; }
            } while (true);
        }// Окончание метода UserChoiceSell

        public void IncorrectSell()
        {
            Console.WriteLine("Удаляемое количество больше текущего остатка. Остаток не может быть отрицательным");
        }

    } // Окончание класса UserDialog
}  // Окончание namespace Books 
