using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var CardsOperation = new CardsDAO(@"/Users/michalmijal/Desktop/c#projects/battle-of-cards-stripmegame/SuperheroClash/Cards.csv");
            var HeroArray = CardsOperation.SplittingFile();
            var NewCards = CardsOperation.CreatingNewCards(HeroArray);
            Console.WriteLine(NewCards[0]);
            //Deck NewDeck = new Deck(NewCards);
            //var NewHand = NewDeck.CreatingNewHand();
            //foreach (var card in NewHand)
            //    card.DisplayingCard();
            //View.MakeCard();
=======
            var Menu = new Options();
            Menu.MainMenuOptions();
            
            bool IsPlaying = true; 

            while(IsPlaying)
            {
                Console.WriteLine("Choose an option by enter a number");
                var Choice = Convert.ToInt16(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.WriteLine("Playing with friend");
                    IsPlaying = false;
                }

                else if (Choice == 2)
                {
                    Console.WriteLine("Playing with computer");
                    IsPlaying = false;
                }
                    
                else if (Choice == 3)
                {
                    Console.WriteLine("Reading rules");
                    IsPlaying = false;
                }

                else if (Choice == 4)
                    IsPlaying = false;

            }
>>>>>>> DominikBranch
        }
    }
}
    