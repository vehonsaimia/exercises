using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklist_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //case 1 Input one number and check, whether it is positive, negative or zero
            Console.WriteLine("Give a number an press enter  ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("you gave number " + number);

            if (number > 0)
                Console.WriteLine("and it is positive");
            else if (number < 0)
                Console.WriteLine("and it is negative");
            else
                Console.WriteLine("and it is zero");
            //stop for a while
            Console.ReadLine();
        }
    }
}
