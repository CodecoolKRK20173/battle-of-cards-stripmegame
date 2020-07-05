﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SuperheroClash
{
    class Program
    {
        static void Main(string[] args)
        {

            var IsPlaying = true;

            while (IsPlaying)
            {
                Options.MainMenuOptions();
                Console.WriteLine("\nChoose an option by enter a number");
                var Choice = Convert.ToInt16(Console.ReadLine());

                if (Choice == 1)
                {
                    GameControllerPlayer gameController = new GameControllerPlayer();
                    gameController.Game();
                }

                else if (Choice == 2)
                {
                    GameControllerAI gameController = new GameControllerAI();
                    gameController.Game();
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
    