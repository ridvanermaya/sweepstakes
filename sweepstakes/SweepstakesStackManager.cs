using System.Collections;
using System.Collections.Generic;

namespace sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        // member variables
        Stack<Sweepstakes> sweepstakesList;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        // constructor
        public SweepstakesStackManager()
        {
            sweepstakesList = new Stack<Sweepstakes>();
        }

        // member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = sweepstakesList.Pop();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakesList.Push(sweepstakes);
        }
    }
}