namespace Calculator_With_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Math Calculator using Function");

            double num1, num2;

            // For num1
            Console.Write("Enter first number: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine($"You entered: {num1}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }

            // For Num2
            Console.Write("Enter second number: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine($"You entered: {num2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }

            double resultAdd = SimpleMath.Add(num1,num2);
            Console.WriteLine(resultAdd);

            double resultSub = SimpleMath.Subtract(num1,num2);
            Console.WriteLine(resultSub);

            double resultMul = SimpleMath.Multiply(num1,num2);
            Console.WriteLine(resultMul);

            double resultDiv = SimpleMath.Divide(num1,num2);
            Console.WriteLine(resultDiv);

        }
    }
}
