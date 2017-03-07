using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculates ! for a given number. Coding time 20minutes.

            Console.WriteLine("Give a number to calculate ! for");
            int value = int.Parse(Console.ReadLine());
            int result = 1;

            while (value < 0)
            {
                Console.WriteLine("Number must be positive, enter new number");
                value = int.Parse(Console.ReadLine());
            }
           if (value == 0)
            { Console.WriteLine("Result is 0"); }
                
            else  
            {
                while (value >= 2)
                {
                    result = (result * value--);
                }

                Console.WriteLine("Result is  " + result);
            }
            Console.WriteLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();

        }
    }
}
