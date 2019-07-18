using System;
using System.Collections.Generic;

namespace sweepstakes
{
    public class MarketingFirm
    {
        // member variables
        ISweepstakesManager manager;

        // constructor
        public MarketingFirm()
        {
            
        }

        // member methods
        public void CreateSweepstake()
        {
            string name = UserInterface.SetSweepstakesName();
            manager.InsertSweepstakes(new Sweepstakes(name));
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

        public ISweepstakesManager ChooseManagerType()
        {
            int manager = UserInterface.ChooseManagerType();
            switch (manager)
            {
                case 1:
                    return new SweepstakesStackManager();
                case 2:
                    return new SweepstakesQueueManager();
                default:
                    return ChooseManagerType();
            }
        }
    }
}