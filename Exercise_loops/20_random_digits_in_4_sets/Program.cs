using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_random_digits_in_4_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shows random 5 numbers in  4 sets
            // Coding time 21 minutes. !! Took some time to move Random r = new Random(); to the beginning

            int counter1 = 1;
            int counter2 = 1;
            Random r = new Random();

            while (counter1 <= 4)
            {
                Console.Write("set " + counter1 + " :  ");

                {
                    while (counter2 <= 5)
                    {
                        int value1 = r.Next(0, 50);             
                        Console.Write(value1 + ", ");
                        counter2++;  
                    }

                    counter2 = 1;

                    Console.WriteLine();
                    counter1++;
                    
                }
            }

            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
        }
    }
}
