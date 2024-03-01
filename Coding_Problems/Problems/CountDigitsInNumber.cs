using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Problems
{
    internal static class CountDigitsInNumber
    {
        public static int CountDigits(int number)
        {
            int count =0;
            
            while(number > 0)
            {
                number = number / 10;
                count++;
            }

            return count;
        }
    }
}
