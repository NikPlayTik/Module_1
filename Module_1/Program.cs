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
                Console.WriteLine("---Меню---");
                Console.WriteLine("1. Конвертация температуры");
                Console.WriteLine("2. Проверка на четность/нечетность");
                Console.WriteLine("3. Проверка на палиндром");
                Console.WriteLine("4. Поиск города");
                Console.WriteLine("5. Игра в угадывание числа");
                Console.WriteLine("0. Выход");

                string choiceNumber = Console.ReadLine();

                switch (choiceNumber)
                {
                    case "1":
                        Console.Write("Введите температуру: ");
                        double temperature = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Выберите действие:");
                        Console.WriteLine("1. Цельсии в Фаренгейты");
                        Console.WriteLine("2. Фаренгейты в Цельсии");
                        string option = Console.ReadLine();
                        if (option == "1")
                        {
                            double result = TemperatureConverter.CelsiusToFahrenheit(temperature);
                            Console.WriteLine($"Результат: {result} градусов Фаренгейта");
                        }
                        else if (option == "2")
                        {
                            double result = TemperatureConverter.FahrenheitToCelsius(temperature);
                            Console.WriteLine($"Результат: {result} градусов Цельсия");
                        }
                        break;

                    case "2":
                        Console.Write("Введите целое число: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        bool isEven = EvenOddChecker.IsEven(num);
                        Console.WriteLine(isEven ? "Четное" : "Нечетное");
                        break;

                    case "3":
                        Console.Write("Введите строку: ");
                        string input = Console.ReadLine();
                        bool isPalindrome = PalindromeChecker.IsPalindrome(input);
                        Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");
                        break;

                    case "4":
                        string[] cities = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Казань" };
                        Console.Write("Введите название города: ");
                        string cityName = Console.ReadLine();
                        int cityIndex = CityFinder.FindCityIndex(cities, cityName);
                        if (cityIndex != -1)
                        {
                            Console.WriteLine($"Город найден. Индекс: {cityIndex}");
                        }
                        else
                        {
                            Console.WriteLine("Город не найден.");
                        }
                        break;

                    case "5":
                        NumberGuessingGame.PlayGame();
                        break;

                    case "0":
                        
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
