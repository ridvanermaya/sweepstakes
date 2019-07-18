using System;
using System.Collections.Generic;

namespace sweepstakes
{
    public class MarketingFirm
    {
        // member variables
        ISweepstakesManager manager;

        // constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
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
    }
}