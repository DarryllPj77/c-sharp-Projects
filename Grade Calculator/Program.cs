using Grade_Calculator.MathCalculator;
using System.Threading.Channels;
namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            int choice = 0;
            object result = 0;

            do
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a number to what arithmetic will be used: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        result = BasicArithmetic.AddNumbers(num1, num2);
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case 2:
                        result = BasicArithmetic.SubNumbers(num1, num2);
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case 3:
                        result = BasicArithmetic.MultiNumbers(num1, num2);
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case 4:
                        result = BasicArithmetic.DivNumbers(num1, num2);
                        Console.WriteLine($"The result is: {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            } while (choice >= 4);

            //object result1 = Calculator.AddNumbers(num1, num2);
            //object result2 = Calculator.Subtraction(num1, num2);

            //Console.WriteLine($"The result is: {result1}");
            //Console.WriteLine($"The result is: {result2}");

        }
    }
}
