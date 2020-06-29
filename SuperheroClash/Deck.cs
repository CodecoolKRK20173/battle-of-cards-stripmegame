﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SuperheroClash
{
	public class Deck
	{
		private List<Card> Cards;
		public Deck(List<Card> cards)
		{
			this.Cards = cards;
		}

		public List<Card> CreatingNewHand()
        {
			List<Card> newHand = new List<Card>();
			Random random = new Random();
			List<int> DrawnCards = new List<int>();
            for (int i = 0; i < 30; i++)
            {
				var choosingCard = true;
				while(choosingCard)
                {
					int index = random.Next(0, 60);
					if (DrawnCards.Contains(index))
						continue;
					newHand.Add(Cards[index]);
					DrawnCards.Add(index);
					choosingCard = false;
                }
            }
			return newHand;
        }
    }
}

