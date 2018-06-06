using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class FishBat : IBaseballBat
    {
        public int WeightInGrams { get; set; }

        public void Swing()
        {
            Console.WriteLine("Silly user, you picked the wrong thing. You get a fish bat.");
            Console.WriteLine("Slap");
        }
    }
}
