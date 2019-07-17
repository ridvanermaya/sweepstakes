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
            Console.WriteLine("Enter contestant's email address: Ex:[ridvanermaya@gmail.com");
            string email = Console.ReadLine().ToString();
            return email;
        }

        public static int SetContestantRegNumber()
        {
            
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
    }
}