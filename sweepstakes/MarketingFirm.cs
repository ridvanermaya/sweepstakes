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
            UserInterface.StartingApp();
        }

        public void AddSweepstakesStackManager(string name)
        {
            SweepstakesStackManager manager = new SweepstakesStackManager();
            manager.Name = name;
        }

        public void AddSweepstakesQueueManager(string name)
        {
            SweepstakesQueueManager manager = new SweepstakesQueueManager();
            manager.Name = name;
        }

        public void ChooseManagerType()
        {
            manager = UserInterface.ChooseManagerType();
            switch (manager)
            {
                
                default:
            }
        }
    }
}