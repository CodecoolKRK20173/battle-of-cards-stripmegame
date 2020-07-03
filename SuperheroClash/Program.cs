using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {
            //var CardsDao = new CardsDAO(@"/Users/michalmijal/Desktop/c#projects/battle-of-cards-stripmegame/SuperheroClash/Cards.csv");
            //var Array = CardsDao.SplittingFile();
            //var NewCards = CardsDao.CreatingNewCards(Array);
            //var Hand = NewCards.CreatingNewHand();
            //Console.WriteLine(NewCards);

            GameController gameController = new GameController();

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
    