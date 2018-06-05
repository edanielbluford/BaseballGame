using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class BaseballPlayer 
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

            Console.WriteLine("Number{0}, {1} takes a step up to bat", this.Name, this.Number);
            Console.WriteLine("Here's the pitch, and...");
            bat.Swing();


        }
    }
}
