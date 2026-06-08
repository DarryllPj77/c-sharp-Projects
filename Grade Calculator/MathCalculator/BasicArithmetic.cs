using System;
using System.Collections.Generic;
using System.Text;

namespace Grade_Calculator.MathCalculator
{
    internal class BasicArithmetic
    {
        public static double AddNumbers(double a, double b)
        {
            return a + b;
        }

        public static double SubNumbers(double a, double b)
        {
            return a - b;
        }

        public static double MultiNumbers(double a, double b)
        {
            return a * b;
        }

        public static double DivNumbers(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero. Divisor must not be zero.");
            }
            return a / b;
        }
    }
}
