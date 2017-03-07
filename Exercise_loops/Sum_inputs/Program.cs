using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_inputs
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sums up given numbers. Checking that there is set than 0 input.
            // Coding time 16 minutes.

            int summary = 0;

            Console.Write("How many numbers do you want to sum up?  ");
            int value = int.Parse(Console.ReadLine());
            int counter = 1;

            if (value < 0)
            {
                Console.WriteLine("Input must be positive, enter again");
                value = int.Parse(Console.ReadLine());
            }
            else
                while (counter <= value)
                {
                    Console.Write("enter " + counter + ":  ");
                    summary = (summary + int.Parse(Console.ReadLine()));
                    counter++;
                }

            Console.WriteLine("Summary is  " + summary);

            Console.WriteLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
