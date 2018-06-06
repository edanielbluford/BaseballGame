using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class CrabPersonPlayer : IPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public CrabPersonPlayer()
        {
            //default constructor
        }


        public CrabPersonPlayer()
        {
            this.Name
        }
        public void TakeTurn(IBaseballBat bat)
        {
            bat.Swing();
        }
    }
}
