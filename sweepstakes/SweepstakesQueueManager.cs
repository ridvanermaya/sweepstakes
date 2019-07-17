using System.Collections;

namespace sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables
        Queue sweepstakesList;

        // constructor
        public SweepstakesQueueManager()
        {
            sweepstakesList = new Queue();
        }
        // member methods
        public Sweepstakes GetSweepstakes()
        {
            throw new System.NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesList.Enqueue(sweepstakes);
        }
    }
}