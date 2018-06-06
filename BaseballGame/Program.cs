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


            //BaseballPlayer hank = new BaseballPlayer("Ty Cobb", 20);
            bool exitresponse = true;
            while(exitresponse == true)
            {
                IPlayer player;
                IBaseballBat bat;
                
                

                Console.WriteLine("Choose your player");
                Console.WriteLine("1. Hank, 2. Wortham, 3. Tony");
                int playerchoice = int.Parse(Console.ReadLine());

                switch (playerchoice)
                {
                    case 1: player = new BaseballPlayer("Hank", 20);
                            break;
                    case 2: player = new CricketPlayer("Wortham", 11);
                        break;
                    default: player = new BaseballPlayer("Tony", 14);
                        break;
                        
                }
                Console.WriteLine("{0}, you're in the dugout. Which bat do you choose?", player.Name);
                Console.WriteLine("1 for Aluminum. 2 for Wooden 3. for Composite.");
                int batchoice = int.Parse(Console.ReadLine());


                
                switch (batchoice)
                {
                    case 1:
                        bat = new AluminumBat();
                        break;
                    case 2:
                        bat = new WoodenBat();
                        break;
                    case 3:
                        bat = new CompositeBat();
                        break;
                    default: bat = new WoodenBat();
                        break;


                }

                player.TakeTurn(bat);
                
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
