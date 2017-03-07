using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shows values from 1 to 10 and the squareroot of the value
            // Coding time 10 minutes

            int counter = 1;
            double result = 1;
            
            
            while (counter <= 10)
            {
                result = Math.Round(Math.Sqrt(counter), 2);
                
                Console.WriteLine("No. " + counter + "   square root = " + result);
                counter++;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
