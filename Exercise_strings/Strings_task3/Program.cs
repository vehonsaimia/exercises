using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count number of specied character in a string. Lower and upper case are considered equal

            // Time used: Prestudy 12:10-12:15 , programming 12:23-:. Total elapsed time  minutes.

            
                Console.WriteLine("Enter the character to match");
            string searchfor = Console.ReadLine();
                string searchforUpper = searchfor.ToUpper();
            Console.WriteLine("Enter a word or sentence");
            string sentence = Console.ReadLine();
                string sentenceUpper = sentence.ToUpper();

            int strlength = sentenceUpper.Length;
                //Console.WriteLine(strlength);
            int strcounter = 0;
            int casesfound = 0;

            //Console.WriteLine(sentenceUpper.Contains(searchforUpper));


            while (strcounter < strlength)
            {               
                   //Console.WriteLine(sentenceUpper.Substring(strcounter, 1) + " " + strcounter + " " + casesfound);

                if (searchforUpper == sentenceUpper.Substring(strcounter, 1))
                {
                    casesfound = casesfound + 1;
                    strcounter = strcounter + 1;
                }

                else
                    strcounter = strcounter + 1;
                
            }

            Console.WriteLine("Found " + casesfound + " matches");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
