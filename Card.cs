using System;

namespace SuperheroClash
{
    public class Card
    {
        private int Rank;
        private string Name;
        private string Type;
        private int State;

        public Card(int rank, string name, string type, int state)
        {
            this.Rank = rank;
            this.Name = name;
            this.Type = type;
            this.State = state;
        }


    }
}

