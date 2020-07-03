using System;
using System.Text;
using System.Security.Principal;

namespace SuperheroClash
{
    public class Card
    {
        public int Rank;
        public int Power;
        public int Inteligence;
        public int Strength;
        public string Name;
        public string Team;
        private int State;
        public int StatToCompare { get; set;}

        public Card(int rank, int power, int inteligence, int strength, string name, string team)
        {
            this.Rank = rank;
            this.Power = power;
            this.Inteligence = inteligence;
            this.Strength = strength;
            this.Name = name;
            this.Team = team;
            StatToCompare = 0;
        }
        
        /*public void DisplayingCard()
        {
            Console.WriteLine("Rank: {0}", Rank);
            Console.WriteLine("Power: {0}", Power);
            Console.WriteLine("Inteligence: {0}", Inteligence);
            Console.WriteLine("Strength: {0}", Strength);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Team: {0}", Team);
        }*/
        

    }
}

