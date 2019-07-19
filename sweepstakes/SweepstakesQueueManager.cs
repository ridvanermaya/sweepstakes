using System;
using System.Collections;
using System.Collections.Generic;

namespace sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager, ISubscriber
    {
        // member variables
        public Queue<Sweepstakes> sweepstakesList;

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

        public void Notify(ISubscriber subscriber)
        {
            Console.WriteLine("Done");
        }
    }
}