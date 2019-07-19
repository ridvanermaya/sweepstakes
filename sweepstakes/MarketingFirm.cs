using System;
using System.Collections.Generic;

namespace sweepstakes
{
    public class MarketingFirm
    {
        // member variables
        ISweepstakesManager manager;
        private List<ISubscriber> subscribers;

        // constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            subscribers = new List<ISubscriber>();
        }

        // member methods
        private string SetSweepstakesName()
        {
            string sweepsteakesName = UserInterface.SetSweepstakesName();
            return sweepsteakesName;
        }

        public Sweepstakes CreateSweepStakes()
        {
            Sweepstakes sweepstakes;
            return sweepstakes = new Sweepstakes(SetSweepstakesName());
        }

        public Contestant CreateContestent()
        {
            Contestant contestant = new Contestant();
            return contestant;
        }

        public void RunApp()
        {
            Console.Clear();
            UserInterface.WelcomeMessage();
            UserInterface.AppInfo();
        }

        public void Subscribe(ISubscriber subcriber)
        {
            subscribers.Add(subcriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Notify(subscriber);
            }
        }
    }
}