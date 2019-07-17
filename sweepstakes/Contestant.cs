namespace sweepstakes
{
    public class Contestant
    {
        // member variables
        private int firstName;
        public int FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private int lastName;
        public int LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int emailAddress;
        public int EmailAddress
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
        public Contestant(string firstName, string lastName, string emailAddress, int regNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.regNumber = regNumber;
        }
        
        // member methods
    }
}