using System;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {
            var CardsOperation = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var HeroArray = CardsOperation.SplittingFile();
            var NewCards = CardsOperation.CreatingNewCards(HeroArray);
            Deck NewDeck = new Deck(NewCards);
            var NewHand = NewDeck.CreatingNewHand();
            foreach (var card in NewHand)
                card.DisplayingCard();
            View.MakeCard();
        }
    }
}
    