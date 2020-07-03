using System.Collections.Generic;
using System;

namespace SuperheroClash
{
    public class GameController
    {
        public Hand Hand { get; set; }
        public Deck Deck { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        private IComparer<Card> Comparer { get; set; }

        public GameController()
        {
            Deck = GetDeck();
            var Player1 = new Player("Player1", true);
            Player1.Hand.CardsInHand = Deck.CreatingNewHand();
            var Player2 = new Player("Player2", false);
            Player2.Hand.CardsInHand = Deck.CreatingNewHand();
            var Comparer = new CardComparer();
            PickStat(Player1, Player2);
        }

        public void PickStat(Player player1, Player player2)
        {
            int inputStat = 3; //int.Parse(Console.ReadLine());
            player1.PickStat(inputStat);
            player2.PickStat(inputStat);
        }

        private void SwitchActiveplayer(Player player1, Player player2)
        {
            player1.IsActive = false;
            player2.IsActive = true;
        }

        private int CompareCards()
        {
            return Comparer.Compare(Player1.Hand.CardsInHand[0], Player2.Hand.CardsInHand[0]);
        }

        public Deck GetDeck()
        {
            var CardsDao = new CardsDAO(@"/Users/michalmijal/Desktop/c#projects/battle-of-cards-stripmegame/SuperheroClash/Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            return Deck;
        }


    }
}