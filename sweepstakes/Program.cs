using System;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm marketingFirm = new MarketingFirm();
            Sweepstakes sweepstakes;
            Contestant contestant;
            sweepstakes = marketingFirm.CreateSweepstake();
            contestant = marketingFirm.CreateContestent();
            sweepstakes.RegisterContestant(contestant);
            contestant = marketingFirm.CreateContestent();
            sweepstakes.RegisterContestant(contestant);
            contestant = marketingFirm.CreateContestent();
            sweepstakes.RegisterContestant(contestant);
            contestant = marketingFirm.CreateContestent();
            sweepstakes.RegisterContestant(contestant);
            contestant = marketingFirm.CreateContestent();
            sweepstakes.RegisterContestant(contestant);
            string winner = sweepstakes.PickWinner();
            Console.WriteLine(winner);
            winner = sweepstakes.PickWinner();
        }
    }
}
