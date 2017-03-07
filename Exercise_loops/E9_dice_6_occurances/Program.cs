using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9_dice_6_occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            // programme rolls a dice 1000 times with  random results of the games and shows the occurances of number 6
            // coding time 13 minutes

            Random dice = new Random();
            int result = 0;
            int counterTimes = 0;
            int occurances = 0;


            while (counterTimes < 100)
            {
                counterTimes++;
                result = dice.Next(1, 7);
                if (result == 6)
                {
                    occurances++;
                    Console.WriteLine(counterTimes + "  " + result);
                }
                else
                {
                    Console.WriteLine(counterTimes + "  " + result);
                }
                
            }
            Console.WriteLine("Number 6 occured " + occurances + " times out of " + counterTimes + " casts");
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
