using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer hank = new BaseballPlayer("Ty Cobb", 20);
            bool exitresponse = true;
            while(exitresponse == true)
            {
                var bat = new AluminumBat();
                var notbat = new WoodenBat();
                Console.WriteLine("{0}, you're in the dugout. Which bat do you choose?", hank.Name);
                Console.WriteLine("1 for Aluminum. 2 for Wooden.");
                int batchoice = int.Parse(Console.ReadLine());


                

                switch (batchoice)
                {
                    case 1:
                        hank.TakeTurn(bat);
                        break;
                    case 2:
                        hank.TakeTurn(notbat);
                        break;

                }
               
                
                Console.WriteLine("Would you like to swing again?");
                string exitconfirm = Console.ReadLine().ToLower();
                if (exitconfirm.Equals("yes"))
                {
                    exitresponse = true;
                }
                else
                {
                     exitresponse = false;
                }
            }
            
        }
    }
}
