using System;
using System.Collections.Generic;

namespace SuperheroClash
{
    public class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public bool IsActive { get; set; }
        public bool HasLost { get; set; }
        public enum Stats
        {
            Power = 1,
            Inteligence = 2,
            Strength = 3
        }

        private List<int> _statsToCompare = new List<int>()
        {
            (int)Stats.Power,
            (int)Stats.Inteligence,
            (int)Stats.Strength
        };

        public Player(string name, bool isActive)
        {
            Name = name;
            Hand = new Hand();
            IsActive = isActive;
        }

        public int PickStat(int inputStat)
        { 
            while (! _statsToCompare.Contains(inputStat))
            {
                try
                {
                    if (!_statsToCompare.Contains(inputStat)) throw new ArgumentException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter 1, 2, or 3.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Enter 1, 2 or 3.");
                }
            }
            SetStatToCompare(inputStat);
            return inputStat;
        }

        private void SetStatToCompare(int stat)
        {
            switch (stat)
            {
                case 1:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Power;
                    break;
                case 2:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Inteligence;
                    break;
                case 3:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Strength;
                    break;
            }
        }


        public void SetHasLost()
        {
            if(Hand.IsEmpty == true)
            {
                HasLost = true;
            }
        }



    }
}
