using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Calculating the price for an entry ticket to a Farm exhibition
             * Normal ticket price 16€
             * ages under 7 years for free
             * ages 65 and higher gets 50% discount
             * ages 7-15 gets 50% discount
             * member of Mtk gets 15% discount
             * "in army"-discount is 50%
             * student discount is 45%
             * Only one discount allowed: *  EXCEPTION A student, who is a member of MTK gets both discounts
             */
            
            //Gathering entry information

            Console.WriteLine("Please, fill in following information ");
            Console.WriteLine();
            Console.Write("Give your age :  ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you a member of MTK? y/n  ");
            string MemberOfMTK = Console.ReadLine();
            Console.WriteLine("Are you doing your military service? y/n  ");
            string InArmy = Console.ReadLine();
            Console.WriteLine("Are you student? y/n  ");
            string Student = Console.ReadLine();
            var FullPrice = 16;
            Double PriceToPay = 1;

            //Conditions and calculating the ticket price
            if (Age < 7)
                PriceToPay = 0;
            
            else if (Age >= 7  && Age < 15)
               PriceToPay = (FullPrice * 0.5);
           
            else if (Age >= 65)
                PriceToPay = (FullPrice * 0.5);
          
            else if (InArmy == "y")
                PriceToPay = (FullPrice * 0.5);       
           
            else if (Student == "y")
                PriceToPay = FullPrice * 0.55;
                        
            else if (Student == "y" && MemberOfMTK == "Y")
                PriceToPay = FullPrice * 0.85 * 0.55;
                        
            else if (MemberOfMTK == "y")
                PriceToPay = FullPrice * 0.15;
                         

            else
                PriceToPay = FullPrice;

           Console.WriteLine("Your ticket price is " + PriceToPay + "eur");

            // freeze view
            Console.ReadLine();
        }
    }
}
