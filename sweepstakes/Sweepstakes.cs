using System;
using System.Collections.Generic;

namespace sweepstakes
{
    public class Sweepstakes
    {
        // member variables
        public Dictionary<int, Contestant> contestants;
        string name;
        Random rng;
        int regNumberCount;


        // constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            rng = new Random();
            this.name = name;
            regNumberCount = 20190000;
        }

        // member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(regNumberCount, contestant);
            regNumberCount++;
        }

        public string PickWinner()
        {
            int randomNumber = rng.Next(20190000, (20190000 + contestants.Count));
            Contestant winnerContestant;
            winnerContestant = contestants.GetValueOrDefault(randomNumber);
            string winner = $"{winnerContestant.FirstName} + {winnerContestant.LastName} won the sweepstakes. Registration Number: {randomNumber}";
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestantInformation(contestant);
        }
    }
}