using System;
using System.Drawing;
using System.Text;
using System.Security.Principal;


namespace SuperheroClash
{
	public class View 
	{
        public const int _TOPCARD = 0;

		public View()
		{
		}

        public void DispalyingTable(Player actualPlayer, Player player1, Player player2)
        {
            Console.Clear();
            Console.WriteLine("{0} turn\n", actualPlayer.Name);
            Console.WriteLine("Number of cards in {0}'s hand: {1}", player1.Name, player1.Hand.CardsInHand.Count);
            Console.WriteLine("{0}'s card\n", player1.Name);
            Console.WriteLine(player1.Hand.CardsInHand[_TOPCARD]);
            Console.WriteLine("Number of cards in {0}'s hand: {1}", player2.Name, player2.Hand.CardsInHand.Count);
            Console.WriteLine("{0}'s card\n", player2.Name);
            Console.WriteLine(player2.Hand.CardsInHand[_TOPCARD]);
        }

    }
}