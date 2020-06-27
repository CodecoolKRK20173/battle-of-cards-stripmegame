using System;
using System.Security.Principal;

namespace SuperheroClash
{
    public class Card
    {
        private int Rank;
        private int Power;
        private int Inteligence;
        private int Strength;
        private string Name;
        private string Team;
        private int State;

        public Card(int rank, int power, int inteligence, int strength, string name, string team)
        {
            this.Rank = rank;
            this.Power = power;
            this.Inteligence = inteligence;
            this.Strength = strength;
            this.Name = name;
            this.Team = team;
        }
        
        public void DisplayingCard()
        {
            Console.WriteLine("Rank: {0}", Rank);
            Console.WriteLine("Power: {0}", Power);
            Console.WriteLine("Inteligence: {0}", Inteligence);
            Console.WriteLine("Strength: {0}", Strength);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Team: {0}", Team);
        }

    }
}

