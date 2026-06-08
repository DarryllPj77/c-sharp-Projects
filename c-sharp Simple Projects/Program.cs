using System.Security.Cryptography.X509Certificates;
using System.Transactions;

using c_sharp_Simple_Projects.MathTools;

namespace c_sharp_Simple_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            int result = Calculator.AddNumbers(5, 10);

            Console.WriteLine($"The result is: {result}");
        }
    }
}
