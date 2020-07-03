using System;
using System.Collections.Generic;
using System.Threading;

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

        /*public int PickStat(int inputStat)
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
        }*/

        public int GetStat(Card card)
        {
            var digits = new List<int>() { 1, 2, 3 };
            int choice = 0;
            var isChosing = true;
            while (isChosing)
            {
                Console.WriteLine("\nEnter a valid number to choose a statistic to fight");
                Console.WriteLine("{0}) {1} - {2}", 1, card.Power, "Power");
                Console.WriteLine("{0}) {1} - {2}", 2, card.Inteligence, "Inteligence");
                Console.WriteLine("{0}) {1} - {2}", 3, card.Strength, "Strength");
                try
                {
                    choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nInvalid value! Try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

                if (!digits.Contains(choice))
                {
                    Console.WriteLine("\nInvalid number! Try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                SetStatToCompare(choice);
                isChosing = false;
            }
            return choice;
        }

        public void SetStatToCompare(int stat)
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
