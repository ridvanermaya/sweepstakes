using System;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerFactory managerFactory = new ManagerFactory();
            ISweepstakesManager manager;
            MarketingFirm marketingFirm;
            manager = managerFactory.CreateItem();
            marketingFirm = new MarketingFirm(manager);
        }
    }
}
