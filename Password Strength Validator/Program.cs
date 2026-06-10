namespace Password_Strength_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            int score = 0;

            Console.WriteLine("Password Strength Validator");
            Console.Write("Enter Password: ");
            password = Console.ReadLine() ?? "";

            //Console.WriteLine(password); // input validator

            // Check length manually
            if (password.Length >= 8)
            {
                score++;
            }

            // Check for uppercase manually
            bool hasUpper = false;
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    hasUpper = true;
                    break;
                }
            }
            if (hasUpper) score++;

            // Check for digits manually
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    hasDigit = true;
                    break;
                }
            }
            if (hasDigit) score++;

            // Check for special characters manually
            bool hasSpecial = false;
            foreach (char c in password)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                {
                    hasSpecial = true;
                    break;
                }
            }
            if (hasSpecial) score++;

            //if (password.Length >= 8)
            //{
            //    score++;
            //}
            //if (password.Any(Char.IsUpper))
            //{
            //    score++;
            //}
            //if (password.Any(Char.IsDigit))
            //{
            //    score++;
            //}
            //if (password.Any(c => !char.IsLetterOrDigit(c)))
            //{
            //    score++;
            //}

            Console.WriteLine("Results");
            Console.WriteLine($"Total Score: {score} out of 4");

            if(score <= 1)
            {
                Console.WriteLine("Strength: Weak!");
            }else if(score == 2)
            {
                Console.WriteLine("Strength: Moderate!");
            }else if(score == 3)
            {
                Console.WriteLine("Strength: Strong!");
            }
            else
            {
                Console.WriteLine("Strength: Unbreakable");
            }

        }
    }
}
