namespace Standard_Statistics_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standard Statistics Console App");

            // Inialization of numbers of data to be input
            int numberData;

            // Initialization of values to each data
            double[] dataValues;


            //Console.Write("Enter number: ");
            while (true)
            {
                Console.Write("Enter number of Data to be Input: ");
                if (int.TryParse(Console.ReadLine(), out numberData))
                {
                    //Console.WriteLine(numberData);
                    dataValues = new double[numberData]; // To identify array length
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }

            // sign data for numbers

            Console.WriteLine("Enter Number: ");
            for (int i = 0; i < dataValues.Length; i++)
            {
                double num = 0;
                while (true)
                {
                    Console.Write($"Data point [{i + 1}]: ");
                    if (double.TryParse(Console.ReadLine(), out num))
                    {
                        dataValues[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }
                
            }

            // 3. Display All Data Points
            Console.WriteLine("\nDisplay All Data Points: ");
            foreach (var item in dataValues)
            {
                Console.WriteLine(item);
            }

            // Logic to get Mean of the data
            double averageResult = StatCalculator.Mean(dataValues);
            Console.WriteLine($"\nThe Mean (Average) is: {averageResult}");

            double medianResult = StatCalculator.Median(dataValues);
            //Console.WriteLine(dataValues[(int)medianResult]);
            Console.WriteLine($"The Median is {medianResult}");

        }
    }
}
