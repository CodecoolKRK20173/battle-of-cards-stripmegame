using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperheroClash
{
    class Hand
    {
        public List<Card> CardsInHand { get; set; }
        private int _StartingHand = 15;

        public Hand()
        {
            List<Card> CardsInHand = new List<Card>();
        }


        public void GetHand()
        {
            CardsInHand = Deck.CreatingNewHand();
        }

        //public void GetHand(Deck deck)
        //{
        //    for (int i = 0; i < _StartingHand; i++)
        //    {
        //        CardsInHand.Add(deck.Deck[0]);
        //        deck.Deck.Remove(deck.DEck[0]);
        //    }
        //}

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public void RemoveCard(Card card)
        {
            CardsInHand.Remove(card);
        }

        public int GetNrOfCardsInHand()
        {
            int _NrOfCards = CardsInHand.Count();
            return _NrOfCards;
        }
    }
}
