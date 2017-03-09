using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_int_bank_reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This exercise creates an international bank invoice reference number for Finnish transaction
               Coding time 2h 10min.
               
            Format
               RFXX1234561, RF is a unique identifier. In Finland RF equals to value "2715"
                            XX is a check caluclation
                            1234561 is a finnish reference. Maximum length is 20, all digits and last digit is a checker.

            */

            // constants
            string rf = "2715";

            // variables
            string freeReference = "";
            string fullReference = "";
            int length = 0;
            double refcode = 0;
            double modulus = 0;
            string strmod = "";

            Console.WriteLine("Calculating the official bank reference code for an invoice from given reference number");
            Console.Write("Give your free reference number, 3 - 19 digits: ");
            freeReference = Console.ReadLine();

            if (freeReference.Length > 19)
                {
                Console.Write("Too long reference number, give again: ");
                freeReference = Console.ReadLine();
                }
            else if (freeReference.Length < 4)
                {
                Console.Write("Too short reference number, give again: ");
                freeReference = Console.ReadLine();
                }
            else
            

            // calculating the validity value to given free reference
            // weights from right 1, 3, 7, ...

            length = freeReference.Length;
                int counter = 0;
                int validity =0;
                string weigths = "7137137137137137137";

            int refCheckSum = 0;
            int refCheckCount = 0;
            
            string fullFreeRef = freeReference;

            do
            {
                fullFreeRef = "0" + fullFreeRef;
                counter++;
            } while (fullFreeRef.Length < 19);

            do
            {
                refCheckSum = refCheckSum + (int.Parse(fullFreeRef.Substring(refCheckCount, 1)) * int.Parse(weigths.Substring(refCheckCount, 1)));
                    //Console.WriteLine(refCheckCount + "  " +int.Parse(fullFreeRef.Substring(refCheckCount, 1)) + "  " + int.Parse(weigths.Substring(refCheckCount, 1)));
                refCheckCount++;
            } while (refCheckCount < 19);

                validity = (10 - (refCheckSum % 10));
            if (validity == 10)
                validity = 0;
            else
                freeReference = freeReference + validity.ToString();
            
            // Calculating check value [strmod]

                fullReference = freeReference + rf + "00";
                    //Console.WriteLine("combined = " + fullReference);
                refcode = double.Parse(fullReference);
                modulus = (98 - (refcode % 97));
                    //Console.WriteLine(modulus);
                strmod = modulus.ToString();
                if (strmod.Length < 2)
                    strmod = "0" + modulus.ToString();
                else
                {
                    strmod = modulus.ToString();
                }
                    //Console.WriteLine("strmod = " + strmod);
                fullReference = "RF" + strmod + freeReference;
                Console.WriteLine();
             Console.WriteLine(fullReference); // RF number without spacing

                // Spacing the RF number
                string refSpaced = fullReference;
                double spacing = (fullReference.Length / 4);
                spacing = Math.Round((spacing - 0.5));
                counter = -1;
                int refSpaceLength = 0;
                do
                {
                    refSpaced = refSpaced.Insert((counter + 5), " ");
                    counter = counter + 5;
                    refSpaceLength = refSpaced.Length;
                } while (counter < (refSpaceLength  - 4));
                Console.WriteLine();
            Console.WriteLine(refSpaced);
                Console.WriteLine();

            // checking the reference number
                string verify = freeReference + "2715" + strmod;
                double verifyVar = double.Parse(verify);
                
                if ((verifyVar % 97) == 1)
             Console.WriteLine("reference number was succesfully build and verified");
                else
                {
             Console.WriteLine("reference number verification failed");
                }

            Console.WriteLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

            
        }
    }

