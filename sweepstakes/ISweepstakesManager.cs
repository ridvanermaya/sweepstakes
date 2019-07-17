namespace sweepstakes
{
    public interface ISweepstakesManager
    {
        // member methods
        void InsertSweepstakes(sweepstakes sweepstakes);
        sweepstakes GetSweepstakes();
    }
}