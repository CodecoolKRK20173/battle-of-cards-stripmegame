using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {

            var CardsDao = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            var Hand = Deck.CreatingNewHand();
            var Options = new Options();
            var Choice = Options.PickStat(Hand[6]);
            Console.WriteLine("Your choice is {0}", Choice);
            //Console.WriteLine(NewCards);

            /*GameController gameController = new GameController();*/

            //gameController.PickStat(gameController.Player1, gameController.Player2);


            //while(IsPlaying)
            //{
            //    Console.WriteLine("Choose an option by enter a number");
            //    var Choice = Convert.ToInt16(Console.ReadLine());

            //    if (Choice == 1)
            //    {
            //        Console.WriteLine("Playing with friend");
            //        IsPlaying = false;
            //    }

            //    else if (Choice == 2)
            //    {
            //        Console.WriteLine("Playing with computer");
            //        IsPlaying = false;
            //    }
                    
            //    else if (Choice == 3)
            //    {
            //        Console.WriteLine("Reading rules");
            //        IsPlaying = false;
            //    }

            //    else if (Choice == 4)
            //        IsPlaying = false;

            //}
        }
    }
}
    