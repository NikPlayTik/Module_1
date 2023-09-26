using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
