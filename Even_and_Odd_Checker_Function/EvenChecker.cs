using System;
using System.Collections.Generic;
using System.Text;

namespace Even_and_Odd_Checker_Function
{
    internal class EvenChecker
    {
        public static bool IsEven(int num)
        {
            bool isEven = true;
            if(num % 2 == 0)
            {
                return isEven;
            }
            else
            {
                return (!isEven);
            }
        }
    }
}
