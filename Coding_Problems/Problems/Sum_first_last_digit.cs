using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Problems
{
    internal static class Sum_first_last_digit
    {

        public static int SumFirstLastDigit(int number)
        {
            int sum = fisrtDigit(number) + lastDigit(number);
            return sum;
        }

        public static int fisrtDigit(int number)
        {
            while (number >10)
            {
                number = number / 10;
            }
            return number;
        }

        public static int lastDigit(int number)
        {
            return number % 10;
        }
    }
}
