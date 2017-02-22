using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;
            int number = 0;
            Console.WriteLine("Give a number");
            bool result = int.TryParse(Console.ReadLine(),out number); 
                if(!result)
            message = "Not a number";
                else if (number % 2 == 0)
                    message = string.Format("number {0} is even", number);
            
            else message = string.Format("number {0} is uneven", number);
            Console.WriteLine(message);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
