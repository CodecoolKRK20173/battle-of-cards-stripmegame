using System;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Main
    {
        static void Main(string[] args)
        {
            var CardsOperation = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var HeroArray = CardsOperation.SplittingFile();
            var NewCards = CardsOperation.CreatingNewCards(HeroArray);
            foreach (Card card in NewCards)
                card.DisplayingCard();

        }
    }
}
    