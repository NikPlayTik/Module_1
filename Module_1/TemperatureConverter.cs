using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class TemperatureConverter
    {
        public static void Temperature()
        {
            // запрос у пользователя ввод значения температуры
            Console.Write("Введите температуру: ");
            float temperature = Convert.ToSingle(Console.ReadLine());

            // выбор единицы конвертации
            Console.WriteLine("Выберите перевод из одной единицы в другую: ");
            Console.WriteLine("1. Цельсии в Фаренгейты");
            Console.WriteLine("2. Фаренгейты в Цельсии");
            byte numberConvert = Convert.ToByte(Console.ReadLine());

            // условие если выбран перевод цельсий в фаренгейты
            if (numberConvert == 1)
            {
                // формула вычисления
                double result = (temperature * 9 / 5) + 32;
                Console.WriteLine($"результат: {result:F1} градусов фаренгейта");
                Console.ReadLine();
            }
            // условие если выбран перевод фаренгейтов в цельсии
            else if (numberConvert == 2)
            {
                // формула вычисления
                double result = (temperature - 32) * 5 / 9;
                Console.WriteLine($"результат: {result:F1} градусов цельсия");
                Console.ReadLine();
            }
        }
    }
}
