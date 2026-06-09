using System;
using System.Collections.Generic;
using System.Text;

namespace Grade_Calculator.ConditionsMethods
{
    internal class Conditions
    {
        internal static double GetValidNumberFromUser(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);

                // If TryParse succeeds, it puts the value in 'result' and evaluates to true.
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result; // Exits the loop and the method, returning the valid number
                }

                // If TryParse fails, it skips the 'if' block and prints the error, then loops again.
                Console.WriteLine("Invalid Input! Please enter a valid number.\n");
            }
        }
    }
}
