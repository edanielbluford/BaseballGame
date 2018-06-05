using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class AluminumBat : IBaseballBat
    {
        public int WeightInGrams { get; set; }

        public AluminumBat()
        {
            //Default Constructor
        }

        public void Swing()
        {
            
            Console.WriteLine("TING!");
        }
    }
}
