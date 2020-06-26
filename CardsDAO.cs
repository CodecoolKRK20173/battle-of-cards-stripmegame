using System;
using System.Collections.Generic;
using System.IO;

namespace SuperheroClash
{
    public class CardsDAO
    {

        private string FilePath;

        public CardsDAO(string filePath)
        {
            this.FilePath = filePath;
        }

        public List<string[]> SplittingFile()
        {
            List<string[]> heroArray = new List<string[]>();
            var newFile = File.ReadAllText(FilePath);
            var cards = newFile.Split(';');
            foreach(var line in cards)
            {
                var hero = line.Split(' ');
                heroArray.Add(hero);
            }
            return heroArray;
        }

        /*public List<Card> CreatingListOfCards()
        {
            List<Card> Cards;
            var newFile = File.ReadAllText(FilePath);
            var cards = newFile.Split(';');
            
        }*/
        
    }

}