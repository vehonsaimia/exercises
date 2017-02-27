using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 counts the number of the characters in the given string. Time used 15 minutes.
            
            Console.WriteLine("Please give a string  ");
            string checkme = Console.ReadLine();

            Console.WriteLine("String length was " + checkme.Length + " characters");

            Console.WriteLine("Press any key to finish ");
            Console.ReadLine();
        }
    }
}
