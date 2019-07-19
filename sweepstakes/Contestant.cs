using System;

namespace sweepstakes
{
    public class Contestant : ISubscriber
    {
        // member variables
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        private int regNumber;
        public int RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        // constructor
        public Contestant()
        {
            this.firstName = UserInterface.SetContestantFirstName();
            this.lastName = UserInterface.SetContestantLastName();
            this.emailAddress = UserInterface.SetContestantEmail();
        }

        

        // member methods
        public void Notify(ISubscriber subscriber)
        {
            Console.WriteLine("Done!");
        }
    }
}