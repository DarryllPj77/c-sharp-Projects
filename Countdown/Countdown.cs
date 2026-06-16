using System;

namespace Countdown;

public class Countdown
{
    public static void CountdownTimer(int n)
    {
        if(n == 0)
        {
            Console.WriteLine("Go");
            return;
        }

        Console.WriteLine(n);
        CountdownTimer(n - 1);
    }
}
