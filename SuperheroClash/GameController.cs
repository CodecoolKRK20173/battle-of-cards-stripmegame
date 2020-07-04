using System.Collections.Generic;
using System;

namespace SuperheroClash
{
    public class GameController
    {
        public List<Card> DrawHand = new List<Card>();
        public Deck Deck { get; set; }
        public Player Player1;
        public Player Player2;
        private IComparer<Card> Comparer { get; set; }
        public Player ActualPlayer;
        private const int _TOPCARD = 0;

        public GameController()
        {
            this.Deck = GetDeck();
            this.Comparer = new CardComparer();
            string name1 = GetName();
            this.Player1 = new Player(name1, true);
            Player1.Hand.CardsInHand = Deck.CreatingNewHand();
            string name2 = GetName();
            this.Player2 = new Player(name2, false);
            Player2.Hand.CardsInHand = Deck.CreatingNewHand();
            this.ActualPlayer = Player1;
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
                Console.WriteLine("{0} turn", ActualPlayer.Name);
                OneRound(Player1, Player2);
                ChangePlayer();
            }
        }


        public void OneRound(Player player1, Player player2)
        {
            Console.WriteLine("{0}'s card\n", player1.Name);
            Console.WriteLine(player1.Hand.CardsInHand[_TOPCARD]);
            Console.WriteLine("{0}'s card\n", player2.Name);
            Console.WriteLine(player2.Hand.CardsInHand[_TOPCARD]);
            int stat = PickStat(ActualPlayer);
            if (ActualPlayer == player1)
                player2.SetStatToCompare(stat);
            player1.SetStatToCompare(stat);
            int comparisonResult = Comparer.Compare(player1.Hand.CardsInHand[_TOPCARD], player2.Hand.CardsInHand[_TOPCARD]);
            GetRoundWinner(comparisonResult, player1, player2);
            if (comparisonResult == 0)
                OneRound(player1, player2);
        }

        private void MoveCards(Player playerWon, Player playerLost)
        {
            playerWon.Hand.AddCard(playerWon.Hand.CardsInHand[_TOPCARD]);
            playerWon.Hand.RemoveCard(playerWon.Hand.CardsInHand[_TOPCARD]);
            playerWon.Hand.AddCard(playerLost.Hand.CardsInHand[_TOPCARD]);
            playerLost.Hand.RemoveCard(playerLost.Hand.CardsInHand[_TOPCARD]);
            foreach (var card in DrawHand)
            {
                playerWon.Hand.AddCard(card);
            }
            DrawHand.Clear();
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
                MoveCardsToDrawHand(Player1, Player2);
            }
        }

        private void MoveCardsToDrawHand(Player player1, Player player2)
        {
            DrawHand.Add(player1.Hand.CardsInHand[_TOPCARD]);
            player1.Hand.RemoveCard(player1.Hand.CardsInHand[_TOPCARD]);
            DrawHand.Add(player2.Hand.CardsInHand[_TOPCARD]);
            player2.Hand.RemoveCard(player2.Hand.CardsInHand[_TOPCARD]);
        }


        private int PickStat(Player player)
        {
            int stat = player.GetStat(player.Hand.CardsInHand[_TOPCARD]);
            return stat;
        }


        private Deck GetDeck()
        {
            var CardsDao = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            return Deck;
        }

        private string GetName()
        {
            Console.WriteLine("Enter your name\n");
            var name = Console.ReadLine();
            return name;

        }

        private void ChangePlayer()
        {
            if (ActualPlayer == Player1)
                ActualPlayer = Player2;
            ActualPlayer = Player2;
        }

    }
}