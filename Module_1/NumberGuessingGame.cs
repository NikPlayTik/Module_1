using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class NumberGuessingGame
    {
        public static void PlayGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int attempts = 3;

            Console.WriteLine("Угадайте число от 1 до 10.");

            while (attempts > 0)
            {
                Console.Write("Попробуйте угадать: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Поздравляем! Вы угадали число.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно. Попробуйте еще раз.");
                        attempts--;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                }
            }

            Console.WriteLine($"Вы проиграли. Загаданное число было: {randomNumber}");
        }
    }
}
