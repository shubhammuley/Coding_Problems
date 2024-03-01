using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Problems
{
    internal static class SumOfDigits
    {
        public static int sum_of_digits(int number)
        {
            int sum = 0;

            while(number >0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }

            return sum;
        }

    }
}
