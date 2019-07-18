namespace sweepstakes
{
    public class ManagerFactory : ICreateManager
    {
        public ISweepstakesManager CreateItem()
        {
            int manager = UserInterface.ChooseManagerType();
            switch (manager)
            {
                case 1:
                    return new SweepstakesStackManager();
                case 2:
                    return new SweepstakesQueueManager();
                default:
                    return CreateItem();
            }
        }
    }
}