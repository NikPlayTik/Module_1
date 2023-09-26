using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class NumberRandom
    {
        public static void PlayGame()
        {
            // обьект класса псевдослучайных чисел
            Random random = new Random();

            // генерация случайного числа от 1 до 10
            int randomNumber = random.Next(1, 11);
            Console.WriteLine("Угадайте число от 1 до 10");

            try
            {
                // ввод с клавиатуры число попыток
                Console.Write("Выберите число попыток: ");
                byte attempts = Convert.ToByte(Console.ReadLine()); // попытки

                // цикл для разгадывания загаданного числа
                while (attempts > 0)
                {
                    Console.Write("Попробуйте угадать: ");
                    // ввод числа с клавиатуры и попытка его парсинга с сохранением в переменную
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        // проверка, совпадает ли угаданное число с загаданным
                        if (guess == randomNumber)
                        {
                            Console.WriteLine("Вы угадали число");
                            Console.ReadLine();
                            break; // выход из цикла, т.к число угадано
                        }
                        else
                        {
                            Console.WriteLine("Попробуйте еще раз");
                            attempts--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                // обработка и вывод ошибки
                Console.WriteLine($"Ошибка: {e.Message}");
                Console.ReadLine();
            }
        }
    }
}
