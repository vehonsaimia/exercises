using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read 3 input numbers and sorts them in ascending order
            Console.WriteLine("Give three numbers and output is sorted in ascending order ");

            // Taking in the numbers
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Show inputs
            Console.Write("You gave numbers " + number1 + " " + number2 + " " + number3);
            Console.WriteLine();
            Console.WriteLine();

            // Creating an array and getting min and max numbers
            int[] numberarray = { number1, number2, number3 };
            var maxNumber = numberarray.Max();
            var minNumber = numberarray.Min();

            // shows min and max values
            Console.WriteLine("Minimium number is " + minNumber);
            Console.WriteLine("Maximum number is " + maxNumber);
            Console.WriteLine();

            // Sorting the whole array in ascending order
            Console.Write("Full sorting is ");
            Array.Sort<int>(numberarray);
            foreach (var number in numberarray)
                Console.Write(" " + number);


            //Freeze the view
            Console.ReadLine();
        }
        
    }
}