using System.Collections.Generic;
using System;

namespace SuperheroClash
{
    public class GameController
    {
        public Hand Hand { get; set; }
        public List<Card> DrawHand = new List<Card>();
        public Deck Deck { get; set; }
        public Player Player1;
        public Player Player2;
        private IComparer<Card> Comparer { get; set; }

        public GameController()
        {
            Deck = GetDeck();
            var DrawHand = new Hand();
            this.Player1 = new Player("Player1", true);
            Player1.Hand.CardsInHand = Deck.CreatingNewHand();
            this.Player2 = new Player("Player2", false);
            Player2.Hand.CardsInHand = Deck.CreatingNewHand();
            var Comparer = new CardComparer();
        }

        public bool GameOn()
        {
            if (Player1.Hand.CardsInHand.Count == 0 || Player2.Hand.CardsInHand.Count == 0)
            {
                return false;
            }
            else
                return true;
        }

        public void Game()
        {
            while (GameOn())
            {
                OneRound(Player1, Player2);

            }
        }


        public void OneRound(Player player1, Player player2)
        {
            var Comparer = new CardComparer();
            if (player1.IsActive)
            {
                //Print Card
                PickStat(player1, player2);
                int comparisonResult = Comparer.Compare(player1.Hand.CardsInHand[0], player2.Hand.CardsInHand[0]);
                GetRoundWinner(comparisonResult, player1, player2);
                if (comparisonResult == 0)
                {
                    OneRound(player1, player2);
                }
            }
        }

        private void MoveCards(Player playerWon, Player playerLost)
        {
            playerWon.Hand.AddCard(playerWon.Hand.CardsInHand[0]);
            playerWon.Hand.RemoveCard(playerWon.Hand.CardsInHand[0]);
            playerWon.Hand.AddCard(playerLost.Hand.CardsInHand[0]);
            playerLost.Hand.RemoveCard(playerLost.Hand.CardsInHand[0]);
            foreach (var card in DrawHand)
            {
                playerWon.Hand.AddCard(card);
            }
        }

        private void GetRoundWinner(int comparisonResult, Player Player1, Player Player2)
        {
            if (comparisonResult == 1)
            {
                Console.WriteLine("Player1 won the round.");
                MoveCards(Player1, Player2);
            }
            if (comparisonResult == -1)
            {
                Console.WriteLine("Player2 won the round.");
                MoveCards(Player2, Player1);
            }
            if (comparisonResult == 0)
            {
                Console.WriteLine("It is a draw");
                DrawHand.Add(Player1.Hand.CardsInHand[0]);
                Player1.Hand.RemoveCard(Player1.Hand.CardsInHand[0]);
                DrawHand.Add(Player2.Hand.CardsInHand[0]);
                Player2.Hand.RemoveCard(Player2.Hand.CardsInHand[0]);
            }
        }


        private void PickStat(Player player1, Player player2)
        {
            int inputStat = 3; //int.Parse(Console.ReadLine());
            player1.PickStat(inputStat);
            player2.PickStat(inputStat);
        }

        
        private int CompareCards()
        {
            return Comparer.Compare(Player1.Hand.CardsInHand[0], Player2.Hand.CardsInHand[0]);
        }

        private Deck GetDeck()
        {
            var CardsDao = new CardsDAO(@"/Users/michalmijal/Desktop/c#projects/battle-of-cards-stripmegame/SuperheroClash/Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            return Deck;
        }


    }
}