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

        public Hand()
        {
            List<Card> CardsInHand = new List<Card>();
        }


        public void GetHand(Deck deck)
        {
            CardsInHand = deck.CreatingNewHand();
        }

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
