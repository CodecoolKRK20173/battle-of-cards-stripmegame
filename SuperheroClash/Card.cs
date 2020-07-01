using System;
using System.Text;
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
        public override string ToString()
        {
            string line = "|========================";

            StringBuilder cardStr = new StringBuilder();
            cardStr.AppendLine(line);
            cardStr.AppendLine($"| Rank: {Rank}");
            cardStr.AppendLine($"| Power: {Power}");
            cardStr.AppendLine($"| Inteligence: {Inteligence}");
            cardStr.AppendLine($"| Strength: {Strength}");
            cardStr.AppendLine($"| Name: {Name}");
            cardStr.AppendLine($"| Team: {Team}");
            cardStr.AppendLine(line);

            return cardStr.ToString();
        }

    }
}

