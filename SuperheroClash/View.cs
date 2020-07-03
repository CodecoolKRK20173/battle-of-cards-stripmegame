using System;
using System.Drawing;
using System.Text;
using System.Security.Principal;


namespace SuperheroClash
{
	public class View 
	{
        private Card _card1;
        private Card _card2;

		public View(Card card1, Card card2)
		{
            this._card1 = card1;
            this._card2 = card2;
		}



        public void DisplayingActualCards()
        { 
            string outsideLine = "##=======================##";
            string insideLine = "||-----------------------||";
            string emptyLine = "||                       ||";

            StringBuilder cardStr = new StringBuilder();
            cardStr.AppendLine(outsideLine);
            cardStr.AppendLine($"|| Name: {_card1.Name}");
            cardStr.AppendLine($"|| Team: {_card1.Team}");
            cardStr.AppendLine($"|| Rank: {_card1.Rank}");
            cardStr.AppendLine(emptyLine);
            cardStr.AppendLine(emptyLine);
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Power: {_card1.Power}              ||");
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Inteligence: {_card1.Inteligence}        ||");
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Strength: {_card1.Strength}           ||");
            cardStr.AppendLine(outsideLine);

            Console.WriteLine(cardStr.ToString());
        }
    
	}
}


