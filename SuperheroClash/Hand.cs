using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperheroClash
{
    public class Hand
    {
        public List<Card> CardsInHand { get; set; }
        public bool IsEmpty { get; set; }
        private int _NrOfCards { get; set; }
        //private int _StartingHand = 15;

        public Hand()
        {
            List<Card> CardsInHand = new List<Card>();
        }


        public void GetHand(Deck deck)
        {
            CardsInHand = deck.CreatingNewHand();
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
            _NrOfCards = CardsInHand.Count();
            return _NrOfCards;
        }

        public void SetIsEmpty()
        {
            if (_NrOfCards == 0)
            {
                IsEmpty = true;
            }
        }
    }
}
