using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // TASK 1 Inputs a digit and prints the same amount of asterisks as the value

            int value = 0;
            int doCount = 0;

            Console.WriteLine("Please, give number:  ");
            value = int.Parse(Console.ReadLine());
            
            if (value < 0)
                    Console.WriteLine("Negative numbers are not allowed! Give a positive number: ");
                //value = int.Parse(Console.ReadLine());
        
            else
            
           do
            {
                Console.Write("*");
                doCount = doCount + 1;
            } while (doCount < value);


            // Freeze view
            Console.WriteLine("Press enter to start next task  ");
               Console.ReadLine();
           
            */

            /*
            // TASK 2 Mimimum function- Inputs 2 numbers and returns the smaller one
            Console.WriteLine("This programme returns the smaller value from two given numbers");
            Console.WriteLine("give 1st number");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give 2nd number");
            var input2 = int.Parse(Console.ReadLine());

            int[] array1 = { input1, input2 };
            Console.WriteLine(array1.Min() + "  is smaller");

            // Freeze view
            Console.WriteLine("Press enter to start next task  ");
            Console.ReadLine();
            */

            /*
            // TASK 3  Asking a number within specified range and checking the validity. Re-entry, if not valid.

            var lowlimit = 0;
            var maxlimit = 10000;
            var inputT3 = -1;

            Console.WriteLine("Give a number between " + lowlimit + " - " + maxlimit);
            while(inputT3 < lowlimit || inputT3 > maxlimit)
            {
                inputT3 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("entered number was " + inputT3);

            // Freeze view
            Console.WriteLine();
            Console.WriteLine("Press enter to start next task  ");
            Console.ReadLine();
            */

            // TASK 4  Asking 10 positive numbers. If not valid, error message and re-entry

            int[] numberset = new int[10];
            int NumberT4 = -1;
            int CountT4 = 0;
            int j;
            Console.WriteLine("Input 10 positive numbers ");

            do
            {
                while (NumberT4 < 0)
                {
                    Console.Write("value {0}. ", CountT4 + 1);
                    NumberT4 = int.Parse(Console.ReadLine());
                    if (NumberT4 < 0)
                    Console.WriteLine("negative not allowed, give positive number ");

                }

                    
                numberset[CountT4] = NumberT4;
                CountT4++;
                NumberT4 = -1;

            } while (CountT4 < 10);

            Console.WriteLine("Thank You, press any key to show the inputs ");
            Console.ReadKey();

            // Output for given numbers

            int order = 0;
            int cases = 10;
            for (order = 0; order < cases; order++)             
              Console.Write("{0}  ", numberset[order]);

            // output for the given max number
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("maximum number was  ");
            Console.Write(numberset.Max());
            Console.WriteLine();
            Console.WriteLine("press any key to finish");

            Console.ReadKey();
                    
            

        }
    }
}
