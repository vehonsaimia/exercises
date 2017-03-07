using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBAN_to_IBAN
{
    class Program
    {
        static void Main(string[] args)
            // Converts old account (BBAN format) to new IBAN format. Coding time 3 hours :(
            // Took quite a long time to figure out how to loop check number calculation correctly

        {   // Setting variables
            string bbanInput = "";
            string ibanOut = "";
            string idFI = "1518";
            
            // reading in the account number and trimming to the correct length and removing -

            Console.WriteLine("Give your Finnish BBAN account number  "); 
            bbanInput = Console.ReadLine();
            bbanInput = bbanInput.Trim();
            int remove = bbanInput.IndexOf("-");
            if (remove > 0)
                {
                    bbanInput = bbanInput.Remove(remove, 1); // removes -
                    //Console.WriteLine(bbanInput);
                }
            else
            {
                
            }
            string bbanP1 = bbanInput.Remove(6);
                    //Console.WriteLine(bbanP1);

            string bbanP2 = bbanInput.Substring(6);
                    //Console.WriteLine(bbanP2);

            string bbanMid = "0";
            
            while (bbanMid.Length + bbanP2.Length < 6)
                {
                    bbanMid = bbanMid + "0";
                }
            
            //Console.WriteLine(bbanP1 + bbanMid + bbanP2);

            string IBAN_1 = bbanP1 + bbanMid + bbanP2;
            IBAN_1 = IBAN_1 + idFI;
                 //Console.WriteLine(IBAN_1);

           
            int counter1 = -1 ;

            // Creating the check number

            Random rnd = new Random();
            double ibanOutValue = 0;
            string ibanNo = "";

            do
                {
                int rndCheck1 = rnd.Next(minValue: 0, maxValue: 9);
                int rndCheck2 = rnd.Next(minValue: 0, maxValue: 9);
                    //Console.WriteLine(IBAN_1 + rndCheck1 + rndCheck2);
                ibanNo = IBAN_1 + rndCheck1 + rndCheck2;
                ibanOutValue = double.Parse(IBAN_1 + rndCheck1 + rndCheck2);
                counter1++;
                } while (ibanOutValue % 97 == 1);


            // From number back to string

            string checkNo = "";
            checkNo = ibanNo.Substring(16, 2);
            ibanOut = ibanNo.Remove(12);
            Console.WriteLine();
            Console.WriteLine("Given BBAN account converts to IBAN as: ");
            Console.WriteLine("FI" + checkNo + ibanOut);


            // Final greetings and exit
            
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();




        }
    }
}
