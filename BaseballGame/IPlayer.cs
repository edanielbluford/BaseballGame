using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    interface IPlayer
    {

       string Name { get; set; }
       int Number { get; set; }

        void TakeTurn(IBaseballBat bat);
        
    }
}
