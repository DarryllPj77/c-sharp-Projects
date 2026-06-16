

using System.Runtime.InteropServices;

namespace Factorial_with_recursion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Factorial with Recursion");
        Console.WriteLine("Enter a number: ");

        int n = int.Parse(Console.ReadLine());

        int result = Recursive.Factorial(n, 0);

        Console.WriteLine($"Factorial of {n} is {result}");

        Console.ReadLine();        

    }
}
