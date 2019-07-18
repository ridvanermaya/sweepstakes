using System;

namespace sweepstakes
{
    public static class UserInterface
    {
        // member methods
        public static string SetContestantFirstName()
        {
            Console.WriteLine("Enter contestant's first name: ");
            string firstName = Console.ReadLine().ToString();
            return firstName;
        }

        public static string SetContestantLastName()
        {
            Console.WriteLine("Enter contestant's last name: ");
            string lastName = Console.ReadLine().ToString();
            return lastName;
        }

        public static string SetContestantEmail()
        {
            Console.WriteLine("Enter contestant's email address: Ex:[ridvanermaya@gmail.com]");
            string email = Console.ReadLine().ToString();
            return email;
        }

        public static void DisplayContestantInformation(Contestant contestant)
        {
            Console.WriteLine("Contestant Information");
            Console.WriteLine("======================");
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email Address: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegNumber}");
        }

        public static int ChooseManagerType()
        {
            Console.WriteLine("Please choose manager tpye..");
            Console.WriteLine("[1]:Stack Manager [2]:Queue Manager");
            string userInput = Console.ReadLine();
            int type = ValidateUserInputForIntegers(userInput, "Please enter a number.. /n[1]:Stack Manager [2]:Queue Manager");
            return type;
        }

        public static int ValidateUserInputForIntegers(string userInput, string message) 
        {
            bool isValid;
            int amount;
            do {
                isValid = int.TryParse(userInput, out amount);
                if (!isValid) {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                }
            } while (!isValid);
            return amount;
        }

        public static string SetSweepstakesName()
        {
            Console.WriteLine("Enter sweepstakes name: ");
            string sweepstakesName = Console.ReadLine().ToString();
            return sweepstakesName;
        }

        public static void WelcomeMessage()
        {
            string msg = "----- Welcome to The Sweepstakes Creator -----";
            CenterText(msg);
        }

        public static void CenterText(string msg)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
            Console.WriteLine(msg); 
        }

        public static void AppInfo()
        {
            Console.WriteLine("\nIn this app, you will be able to choose the type of manager.(Queue or Stack)");
            Console.WriteLine("When you choose your manager type, you can create sweepstakes and insert them as the manager.");
            Console.WriteLine("You will be prompted to add contestants to your sweepstakes.");
            Console.WriteLine("You can a")
            Console.WriteLine("When you have your contestants, the app can pick a random winner.");
        }
    }
}