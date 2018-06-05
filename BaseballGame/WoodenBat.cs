using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class WoodenBat : IBaseballBat
    {
        public int WeightInGrams { get; set; }


        public WoodenBat()
        {
            //Default Constructor
        }

        public void Swing()
        {
            Console.WriteLine("CRACK!");
        }
    }
}
