using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // checks whether the given number is even or odd
            Console.WriteLine("Give a number and I will show, it is even or odd ");
            //creating variable and converting a string input to a number
            var givennumber = int.Parse(Console.ReadLine());
            Console.Write("You gave number " + givennumber);
            if (givennumber % 2 == 0)
                Console.WriteLine(" and it is even");
            else
                Console.WriteLine(" and it is odd");


            //stop for a minute
            Console.WriteLine();
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();

        }
    }
}
