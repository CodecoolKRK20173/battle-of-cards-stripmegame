using System;
using System.Collections.Generic;

namespace SuperheroClash
{
    class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public bool IsActive { get; set; }

        public Player(string name, bool isActive)
        {
            Name = name;
            Hand = new Hand();
            IsActive = isActive;
        }



    }
}
