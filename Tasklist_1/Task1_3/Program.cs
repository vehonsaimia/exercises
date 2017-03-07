using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //case 3 Input one number and check, whether it is positive, negative or zero and shows whether it is odd or even
            Console.WriteLine("Give a number an press enter  ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("You gave number " + number);

            if (number > 0)
                Console.Write(" It is positive");
              
            else if (number < 0)
                Console.Write(" It is negative");
            else
                Console.Write("It is zero");

            // oddity

            //checks whether the given number is even or odd
            
            if (number % 2 == 0)
                Console.Write(" and even");
            else
                Console.Write(" and odd");
            Console.ReadLine();

        }
    }
}
