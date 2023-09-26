using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class PalindromeChecker
    {
        public static void Palindrome()
        {
            // ввод строки с клавиатуры
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // создание временной переменной которая будет содержать только буквы и цифры с нижнем регистром
            string input_temp = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

            // создание переменной обратной строки из временной переменной 
            string reversed = new string(input_temp.Reverse().ToArray());

            // условие строки является ли она палиндромом
            if (input_temp == reversed)
            {
                Console.WriteLine($"Строка: {input}, палиндром");
            }
            else
            {
                Console.WriteLine($"Строка: {input}, не палиндром");
            }

            Console.ReadLine();
        }

    }
}
