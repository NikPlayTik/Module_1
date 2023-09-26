using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class ParityNumber
    {
        public static void ParityAndNoParity()
        {
            // ввод целого числа с клавиатуры
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            // условие если с число делится на 2 без остатка
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число: {number}, чётное");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Число: {number}, нечётное");
                Console.ReadLine();
            }
        }
    }
}
