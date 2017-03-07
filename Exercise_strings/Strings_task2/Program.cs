using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converts characters "e" to "@" for the input string
            // Time used: Prestudy 11:56-11:58 , programming 11:59-12:05. Total elapsed time 9 minutes.

            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string output = input.Replace("e", "@");

            Console.WriteLine("Converted string is " + output);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
