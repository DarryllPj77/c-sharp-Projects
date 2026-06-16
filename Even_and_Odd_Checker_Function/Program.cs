namespace Even_and_Odd_Checker_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even/Odd checker using Function");
            int num;
            while (true)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"You Entered: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            bool resultIsEven = EvenChecker.IsEven(num);
            if(resultIsEven == true)
            {
                Console.WriteLine("The number input is Even");
            }
            else
            {
                Console.WriteLine("The number input is Odd");
            }
        }
    }
}
