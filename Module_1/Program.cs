using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // меню выбора
                Console.WriteLine("\t---Меню---");
                Console.WriteLine("1. Конвертация температуры");
                Console.WriteLine("2. Проверка на четность/нечетность");
                Console.WriteLine("3. Проверка на палиндром");
                Console.WriteLine("4. Поиск города");
                Console.WriteLine("5. Игра в угадывание числа");

                string choiceNumber = Console.ReadLine();

                switch (choiceNumber)
                {
                    case "1":
                        Console.Clear();
                        TemperatureConverter.Temperature();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        ParityNumber.ParityAndNoParity();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        PalindromeChecker.Palindrome();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        CityFinder.FindCityIndex();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        NumberRandom.PlayGame();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
