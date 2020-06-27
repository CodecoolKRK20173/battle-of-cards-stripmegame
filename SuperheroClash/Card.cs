using System;

namespace SuperheroClash
{
    public class Card
    {
        private int Rank;
        private string Name;
        private string Team;
        private int State;

        public Card(int rank, string name, string team)
        {
            this.Rank = rank;
            this.Name = name;
            this.Team = team;
        }
        
        public void DisplayingCard()
        {
            Console.WriteLine("Rank: {0}", Rank);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Team: {0}", Team);
        }

    }
}

