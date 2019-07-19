namespace sweepstakes
{
    public interface ISubscriber
    {
        void Notify(ISubscriber subscriber);
    }
}