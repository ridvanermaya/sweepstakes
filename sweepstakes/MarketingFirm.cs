namespace sweepstakes
{
    public class MarketingFirm
    {
        // member variables
        Sweepstakes sweepstakes;
        // constructor
        public MarketingFirm()
        {
            
        }

        // member methods
        public Sweepstakes CreateSweepstake()
        {
            string name = UserInterface.SetSweepstakesName();
            sweepstakes = new Sweepstakes(name);
            return sweepstakes;
        }

        public Contestant CreateContestent()
        {
            Contestant contestant = new Contestant();
            return contestant;
        }
    }
}