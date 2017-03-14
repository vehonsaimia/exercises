using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI_reference_number_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This exercise creates Finnish bank invoice reference number
              Generates new references requested amount
              Coding time 50min.
           */

            // variables
            string freePartReference = "";
            int amount = 0;
            int length = 0;
            int counter = 1;

            Console.WriteLine("Calculating the official bank reference code for ");
            Console.WriteLine("an invoice from given free-choice reference part.");
            Console.WriteLine();
            Console.WriteLine("Note, that total length is between 3 -19 digits");
            Console.WriteLine("base part and number of refrence numbers to create");
            Console.WriteLine();
            Console.Write("Give your free-choice base part reference number: ");
            freePartReference = Console.ReadLine();
            Console.Write("How many reference numbers do you want to generate?  ");
            amount = int.Parse(Console.ReadLine());

            if ((freePartReference.Length + amount.ToString().Length) > 19)
            {
                Console.Write("Too long reference number, give again: ");
                freePartReference = Console.ReadLine();
            }
            else if ((freePartReference.Length + amount.ToString().Length) < 4)
            {
                Console.Write("Too short reference number, give again: ");
                freePartReference = Console.ReadLine();
            }
            else

                do
                {

                    // calculating the validity value to given free reference
                    // weights from right 1, 3, 7, ...

                    length = freePartReference.Length;

                    int validity = 0;
                    string weigths = "7137137137137137137";

                    int refCheckSum = 0;
                    int refCheckCount = 0;

                    string fullFreeRef = freePartReference + counter.ToString();

                    do
                    { fullFreeRef = "0" + fullFreeRef; }
                    while (fullFreeRef.Length < 19);

                    do
                    {
                        refCheckSum = refCheckSum + (int.Parse(fullFreeRef.Substring(refCheckCount, 1)) * int.Parse(weigths.Substring(refCheckCount, 1)));
                        refCheckCount++;
                    } while (refCheckCount < 19);

                    validity = (10 - (refCheckSum % 10));
                    if (validity == 10)
                        validity = 0;
                    else
                        fullFreeRef = fullFreeRef + validity.ToString();

                    int validate = 0;

                    while (validate < 1)
                    {
                        fullFreeRef = fullFreeRef.Remove(0, 1);
                        validate = int.Parse((fullFreeRef.Substring(0, 1)));
                    }


                    Console.WriteLine("reference number " + counter + " " + fullFreeRef);

                    counter++;

                } while (counter <= amount);


            Console.WriteLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
