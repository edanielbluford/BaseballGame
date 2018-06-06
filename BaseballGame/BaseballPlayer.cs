﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class BaseballPlayer : IPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }


        public BaseballPlayer()
        {
            //Default Constructor
        }

        public BaseballPlayer(string name, int number)
        {
            this.Name = name;
            this.Number = number;

    
        }
        public void TakeTurn(IBaseballBat bat)
        {
            bat.Swing();
        }
        public void TakeTurn()
        {
            
        }
    }
}
