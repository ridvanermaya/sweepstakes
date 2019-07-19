using System;
using System.Collections;
using System.Collections.Generic;

namespace sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager, ISubscriber
    {
        // member variables
        public Stack<Sweepstakes> sweepstakesList;

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

        public void Notify(ISubscriber subscriber)
        {
            Console.WriteLine("Done");
        }
    }
}