using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class CricketPlayer : IPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public CricketPlayer()
        {
            //Default Constructor
        }

        public CricketPlayer(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public void TakeTurn(IBaseballBat bat)
        {
            bat.Swing();
        }


    }
}
