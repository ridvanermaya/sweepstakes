using System.Collections;
using System.Collections.Generic;

namespace sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables
        Queue<Sweepstakes> sweepstakesList;

        // constructor
        public SweepstakesQueueManager()
        {
            sweepstakesList = new Queue<Sweepstakes>();
        }
        
        // member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            sweepstakes = sweepstakesList.Dequeue();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesList.Enqueue(sweepstakes);
        }
    }
}