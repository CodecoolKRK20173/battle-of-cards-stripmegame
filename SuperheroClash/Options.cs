using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Serialization;

namespace SuperheroClash
{
	public class Options
	{
		private static List<string> MainMenu = new List<string>() { "Play with friend", "Play with computer", "Game rules", "Quit" };
		public Options()
		{

		}

		public static void MainMenuOptions()
        {
            for (int i = 0; i < MainMenu.Count; i++)
            {
                Console.WriteLine("{0}) {1}", i+1, MainMenu[i]);
            }
        }

		/*public int PickStat(Card card)
        {   
            var digits = new List<int>() { 1, 2, 3 };
            int choice = 0;
            var isChoosing = true;
            while (isChoosing)
            {
                Console.WriteLine("Enter a valid number to choose a statistic to fight");
                Console.WriteLine("{0}) {1} - {2}", 1, card.Power, "Power");
                Console.WriteLine("{0}) {1} - {2}", 2, card.Inteligence, "Inteligence");
                Console.WriteLine("{0}) {1} - {2}", 3, card.Strength, "Strength");
                try
                {
                    choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nInvalid value! Try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

                if (!digits.Contains(choice))
                {
                    Console.WriteLine("\nInvalid number! Try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                isChoosing = false;
            }
            return choice;
        }*/
	}
}


