namespace Countdown;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Countdown");

        while (true)
        {
            Console.Write("Enter a number for the Countdown: ");
            if(int.TryParse(Console.ReadLine(), out int count))
            {
                Console.WriteLine("=====================");
                Console.WriteLine($"You entered {count}");
                Console.WriteLine("=====================");
                Countdown.CountdownTimer(count);
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        
    }
}
