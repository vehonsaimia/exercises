using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shows multiplying table for numbers from 1 to 9
            // Coding time 5 minutes

            int value = 1;

            while (value <= 9)
            { Console.WriteLine(value + " * " + value + " = " + (value * value));
                value++;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
