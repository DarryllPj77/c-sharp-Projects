namespace Sum_from_1_to_N;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sum from 1 to N");
        Console.Write("Enter a number: ");

        while (true)
        {
            if(int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"You entered {num}");
                int resultSum = SumToN.SumToNum(num);
                Console.WriteLine(resultSum);
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            } 
        }



    }
}
