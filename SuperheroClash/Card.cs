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

    }
}

