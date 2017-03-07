using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9_Coin_Flipping
{
    class Program
    {
        static void Main(string[] args)
        {
            // programme asks how many times to flip a coin and calculates the count of heads and tails
            // coding time 18 minutes

            Console.Write("How many times do you want to flip the coin? ");
            int flips = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int counterHeads = 0;
            int counterTails = 0;

            while (flips > (counterTails + counterHeads))
            {
                int flip = rnd.Next(0, 2);
                if (flip == 1)
                    counterTails++;
                else
                {
                    counterHeads++;
                }         
            }

            Console.WriteLine("Coin was flipped " + (counterHeads + counterTails) + " times");
            Console.Write("heads occured " + counterHeads + " times and tails " + counterTails + " times");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
