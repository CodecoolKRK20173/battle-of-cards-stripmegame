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
            var cards = newFile.Split(";\r\n");
            foreach (var line in cards)
            {
                var hero = line.Split(", ");
                heroArray.Add(hero);
            }
            return heroArray;
        }

        public List<Card> CreatingNewCards(List<string[]> heroArray)
        {
            List<Card> cards = new List<Card>();
            foreach(var hero in heroArray)
            {
                var rank = Convert.ToInt32(hero[0]);
                var name = hero[1];
                var team = hero[2];

                var newCard = new Card(rank, name, team);
                cards.Add(newCard);
            }

            return cards;
        }

    }
}

