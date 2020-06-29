using System;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {
            var CardsOperation = new CardsDAO(@"/Users/michalmijal/Desktop/c#projects/battle-of-cards-stripmegame/SuperheroClash/Cards.csv");
            var HeroArray = CardsOperation.SplittingFile();
            var NewCards = CardsOperation.CreatingNewCards(HeroArray);
        }
    }
}
