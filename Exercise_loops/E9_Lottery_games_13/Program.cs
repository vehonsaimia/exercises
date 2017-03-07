using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9_Lottery_games_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // programme gets random results of the games and shows the result as lottery winnings
            // Odds for winning: homeplay (0 -> 0,4), tie (0,4 -> <= 0,6), visitors (0,6 -> <=1)
            // coding time 23 minutes

            
            Random game = new Random();
            var result = 0;
            int counterGames = 1;


            while (counterGames <= 13)
            {
                result = game.Next(0,100);
                if ((result >= 0) && (result <= 40))
                    Console.WriteLine(counterGames + ".  " + "1");
                else if ((result > 40) && (result <= 60))
                    Console.WriteLine(counterGames + ".  " + "X");
                else
                {
                    Console.WriteLine(counterGames + ".  " + "2");
                }
                counterGames++;
            }       

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
