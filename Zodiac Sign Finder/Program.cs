namespace Zodiac_Sign_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            const string year = "2026";

            Console.WriteLine("Zodiac Sign Finder");
            Console.Write("Enter your Name: ");
            name = Console.ReadLine() ?? "";

            Console.WriteLine("Enter your Birthday: ");
            Console.Write("Enter Birth Month: ");

            int month;
            string monthWord = "";
            int day;
            while (true)
            {
                Console.Write("Enter Birth Month (1-12): ");

                if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
                {
                    Console.WriteLine($"You Entered: {month}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            while (true)
            {
                Console.Write("Enter What Day of the Month: ");
                if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
                {
                    Console.WriteLine($"You Entered: {day}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            if(month == 1)
            {
                monthWord = "January";
            }else if(month == 2)
            {
                monthWord = "Febuary";
            }
            else if(month == 3)
            {
                monthWord = "March";
            }
            else if(month == 4)
            {
                monthWord = "April";
            }
            else if (month == 5)
            {
                monthWord = "May";
            }
            else if (month == 6)
            {
                monthWord = "June";
            }
            else if (month == 7)
            {
                monthWord = "July";
            }
            else if (month == 8)
            {
                monthWord = "August";
            }
            else if (month == 9)
            {
                monthWord = "September";
            }
            else if (month == 10)
            {
                monthWord = "October";
            }
            else if (month == 11)
            {
                monthWord = "November";
            }
            else if(month == 12)
            {
                monthWord = "December";
            }
            else
            {
                Console.WriteLine("Invalid Month");
            }

            Console.WriteLine($"Your Birthday is: {monthWord}-{day}-{year}");

            if ((month == 1 && day >= 20) || ((month == 2) && (day <= 18)))
            {
                Console.WriteLine("Your Zodiac Sign is Aquarius");
            }
            else if ((month == 2 && day >= 19) || ((month == 3) && (day <= 20)))
            {
                Console.WriteLine("Your Zodiac Sign is Pisces");
            }
            else if ((month == 3 && day >= 21) || ((month == 4) && (day <= 19)))
            {
                Console.WriteLine("Your Zodiac Sign is Aries");
            }
            else if ((month == 4 && day >= 20) || ((month == 5) && (day <= 20)))
            {
                Console.WriteLine("Your Zodiac Sign is Taurus");
            }
            else if ((month == 5 && day >= 21) || ((month == 6) && (day <= 20)))
            {
                Console.WriteLine("Your Zodiac Sign is Gemini");
            }
            else if ((month == 6 && day >= 21) || ((month == 7) && (day <= 22)))
            {
                Console.WriteLine("Your Zodiac Sign is Cancer");
            }
            else if ((month == 7 && day >= 23) || ((month == 8) && (day <= 22)))
            {
                Console.WriteLine("Your Zodiac Sign is Leo");
            }
            else if ((month == 8 && day >= 23) || ((month == 9) && (day <= 22)))
            {
                Console.WriteLine("Your Zodiac Sign is Virgo");
            }
            else if ((month == 9 && day >= 23) || ((month == 10) && (day <= 22)))
            {
                Console.WriteLine("Your Zodiac Sign is Libra");
            }
            else if ((month == 10 && day >= 23) || ((month == 11) && (day <= 21)))
            {
                Console.WriteLine("Your Zodiac Sign is Scorpio");
            }
            else if ((month == 11 && day >= 22) || ((month == 12) && (day <= 21)))
            {
                Console.WriteLine("Your Zodiac Sign is Sagittarious");
            }
            else if ((month == 12 && day >= 22) || ((month == 1) && (day <= 19)))
            {
                Console.WriteLine("Your Zodiac Sign is Capricorn");
            }

        }
    }
}
