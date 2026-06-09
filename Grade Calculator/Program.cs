using Grade_Calculator.MathCalculator;
using Grade_Calculator.ConditionsMethods;
using System.Threading.Channels;
namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            double result = 0;

            do
            {
                Console.WriteLine("============");
                Console.WriteLine("=Calculator=");
                Console.WriteLine("============");
                double num1 = Conditions.GetValidNumberFromUser("Enter a number: ");
                double num2 = Conditions.GetValidNumberFromUser("Enter another number: ");
                choice = (int)Conditions.GetValidNumberFromUser("Enter a number for what arithmetic will be used: ");
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
                        double divisor = num2;
                        while (divisor == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            divisor = Conditions.GetValidNumberFromUser("Please enter a non-zero divisor: ");
                        }
                        result = BasicArithmetic.DivNumbers(num1, divisor);
                        Console.WriteLine($"The result is: {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            } while (choice != 0 || choice >= 4);

            //object result1 = Calculator.AddNumbers(num1, num2);
            //object result2 = Calculator.Subtraction(num1, num2);

            //Console.WriteLine($"The result is: {result1}");
            //Console.WriteLine($"The result is: {result2}");

        }
    }
}
