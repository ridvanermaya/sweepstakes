using System.Collections.Generic;

namespace sweepstakes
{
    public class sweepstakes
    {
        // member variables
        Dictionary<TKey, TValue> data;
        string name;


        // constructor
        public sweepstakes(string name)
        {
            this.name = name;
        }

        // member methods
        public void RegisterContestant(Contestant contestant)
        {

        }

        public string PickWinner()
        {
            string winner = "Ridvan";
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}