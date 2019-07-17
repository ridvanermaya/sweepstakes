namespace sweepstakes
{
    public interface ISweepstakesManager
    {
        // member methods
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}