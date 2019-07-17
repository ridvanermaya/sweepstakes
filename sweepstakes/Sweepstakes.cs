using System;
using System.Collections.Generic;

namespace sweepstakes
{
    public class Sweepstakes
    {
        // member variables
        Dictionary<int, Contestant> contestants;
        string name;


        // constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        // member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegNumber, contestant);
        }

        public string PickWinner()
        {
            string winner = "Ridvan";
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestantInformation(contestant);
        }
    }
}