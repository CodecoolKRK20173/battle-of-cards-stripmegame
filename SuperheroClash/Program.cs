using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var CardsDao = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            var Hand = Deck.CreatingNewHand();
            var View = new View(Hand[0], Hand[1]);
            View.DisplayingActualCards();*/
            /*var Options = new Options();
            var Choice = Options.PickStat(Hand[6]);
            Console.WriteLine("Your choice is {0}", Choice);*/
            //Console.WriteLine(NewCards);

            var IsPlaying = true;

            while (IsPlaying)
            {
                Options.MainMenuOptions();
                Console.WriteLine("\nChoose an option by enter a number");
                var Choice = Convert.ToInt16(Console.ReadLine());

                if (Choice == 1)
                {
                    GameController gameController = new GameController();
                    gameController.Game();
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
        }
    }
}
    