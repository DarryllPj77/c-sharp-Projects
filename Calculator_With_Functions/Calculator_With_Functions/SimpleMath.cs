using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_With_Functions
{
    internal class SimpleMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return 0;
            }
            return a / b;
        }
    }
}
