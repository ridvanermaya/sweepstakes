using System.Collections;

namespace sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        // member variables
        Stack sweepstakesList;

        // constructor
        public SweepstakesStackManager()
        {
            sweepstakesList = new Stack();
        }

        // member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("red");
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakesList.Push(sweepstakes);
        }
    }
}