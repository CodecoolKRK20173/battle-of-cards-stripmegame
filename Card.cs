using System;

namespace BattleOfCards
{
    public class Card
    {
        int Rank;
        string Name;
        string Type;
        int State;

        public Card(int rank, string name, string type, int state)
        {
            this.Rank = rank;
            this.Name = name;
            this.Type = type;
            this.State = state;
        }


    }
}

