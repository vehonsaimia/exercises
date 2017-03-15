using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This exercise generates national numeric barcode for transactions from given data
             * Full length for the barcode is 54 digits
             * Coding time 2h 40'
                    
            */

     // Setting up parameters
            // constants
                string versionId = "4";

            // variables, INPUTS
                string Iban = "";   // 18 numbers long
                        Iban = "0250004640001302"; // temporary setting for testing, example BILL 3
                string value = "0";  // max 6 digits
                       value = "693,80";  // temporary setting for testing
                int centValue = 0;  // max 2 digits
                        //centValue = 65;  // temporary setting for testing
                string reserve = "000";// max 3 chars, expected 0
                string referenceID = "";    // 20 digits long
                        referenceID = "69875672083435364"; // temporary setting for testing
            //Console.WriteLine(referenceID.Length);
                string dueDate = "";        // format yymmdd  24.7.2011
                        dueDate = "24.7.2011"; // temporary setting for testing, example BILL 3
                string resultBarcode = "";// length 54 characters  RESULT
                                          //[105] 40 25 00 04 64 00 01 30 20 00 69 38 00 00 0 0 06 98 75 67 20 83 43 53 64 11 07 24 [14] [stop]

            // Reading the inputs
            Console.WriteLine("NOTE:  to run the programme correctly");
            Console.WriteLine("remove the note marks // from the input area.");
            Console.WriteLine("Constants are preset to run it through as an example!");
            Console.WriteLine();
            Console.WriteLine("This programme creates a barcode from given invoicing information.");
            Console.WriteLine();
            Console.Write("Give the invoicer´s bank account in IBAN format:  FI");
                // Iban = Console.ReadLine();
            while (Iban.Length < 16)
                Iban = "0" + Iban;

            Console.WriteLine();
            Console.Write("Give the payble amount EUR,c : ");
                // value = Console.ReadLine();
                Console.WriteLine();
            Console.Write("Give the reference number    : ");
                // referenceID = Console.ReadLine();

            while (referenceID.Length < 20)
            {
                referenceID = "0" + referenceID;
                 //Console.WriteLine(referenceID + " length = " + referenceID.Length);
            }
                    
                Console.WriteLine();
            Console.Write("Give the due date dd.mm.yyyy : ");
                // dueDate = Console.ReadLine()
                Console.WriteLine();

      // Building up the barcode

            resultBarcode = "[105]";    // start marker
            resultBarcode = resultBarcode + versionId;  // 4 is a national version
            resultBarcode = resultBarcode + Iban; // adding Iban code

            // converting the payable sum to barcode format
            value = value.Replace(",","");

            do
            {
                value = "0" + value;
            }
            
            while (value.Length < 8);
                    //Console.WriteLine(value); // showing the content of value

            // Converting due date to barcode format
            // dueDate = "24.7.2011"; // temporary setting for testing, example BILL 3

            string dateBarCode = "";
            int dateID = dueDate.IndexOf(".");
                    //Console.WriteLine("date place, " + dateID);
            if (dateID == 2)
                dateBarCode = dueDate.Substring(0, 2);
                else
                dateBarCode = "0" + dueDate.Substring(0, 1);
                    //Console.WriteLine(dateBarCode);

            string monthBarCode = "";
            int monthID = dueDate.IndexOf(".", (dateID + 1));
                    //Console.WriteLine("month place, " + monthID);
            if (monthID == (dateID + 3))
                monthBarCode = dueDate.Substring((monthID -2), 2);
            else
                monthBarCode = "0" + dueDate.Substring((monthID - 1), 1);
                    //Console.WriteLine(monthBarCode);

            string year = dueDate.Substring((dueDate.Length - 2), 2);
                 //Console.WriteLine("year " + year);

       // Building up the barcode

            Console.WriteLine();
            resultBarcode = resultBarcode + value; // adding the payable amount
            resultBarcode = resultBarcode + reserve; // adding reservation part
            resultBarcode = resultBarcode + referenceID; // adding the reference number
            resultBarcode = resultBarcode + year + monthBarCode + dateBarCode; // addding the date

      // Modulo 103 calculation
            string mod103 = resultBarcode.Remove(0,5);
            int valMod103 = 105;          
            
            int place = 0;
            for (int count = 1; count < 28; count++)
                {
                valMod103 = valMod103 + count * int.Parse(mod103.Substring(place, 2));
                    //Console.WriteLine(count + " " + int.Parse(mod103.Substring(place, 2)) + " " + count+ " " + valMod103);
                place = place + 2;
                }
           
            int m103checker = valMod103 % 103;
                // Console.WriteLine("mod103 = " + m103checker);
            string mod103Checker = m103checker.ToString();

            resultBarcode = resultBarcode + "[" + mod103Checker + "][stop]";


      // Showing the generated barcode

            Console.WriteLine("Barcode is:  ");
            Console.WriteLine(resultBarcode);

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
