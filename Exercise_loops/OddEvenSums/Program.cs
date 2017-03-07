using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sums up odds and evens calculated between 0 and given number. Checking that input > 0.
            // Coding time 15 minutes.

         

            Console.Write("Until what value do you want to sum up odds and evens?  ");
            int value = int.Parse(Console.ReadLine());
            int odds = 1;
            int evens = 2;

            int oddsSum = 0;
            int evensSum = 0;

            while (value < 0)
            {
                Console.WriteLine("Input must be positive, enter again");
                value = int.Parse(Console.ReadLine());
            }
            
            while (odds <= value)
                {
                    oddsSum = (oddsSum + odds);
                    Console.Write(odds + " ");
                    odds = (odds + 2);
                }
                Console.WriteLine("Sum of odds = " + oddsSum);

            while (evens < value)
                {
                    evensSum = (evensSum + evens);
                    Console.Write(evens + " ");
                    evens = (evens + 2);
                }
                Console.WriteLine("Sum of evens = " + evensSum);

            Console.WriteLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
