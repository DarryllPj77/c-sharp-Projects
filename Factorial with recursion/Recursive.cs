using System;

namespace Factorial_with_recursion;

public class Recursive
{
    public static int Factorial(int n, int depth)
    {
        // indent based on depth so we can see levels
        string indent = new string(' ', depth * 2);

        Console.WriteLine($"{indent}Calling Factorial({n})");

        if (n == 0)
        {
            Console.WriteLine($"{indent}Base case reached: return 1");
            return 1;
        }

        // recursive call
        int smaller = Factorial(n - 1, depth + 1);

        int result = n * smaller;

        Console.WriteLine($"{indent}Returning {n} * {smaller} = {result}");

        return result;
    }
}

