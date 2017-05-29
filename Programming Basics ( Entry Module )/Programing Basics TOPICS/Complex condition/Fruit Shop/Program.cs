using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var amount = double.Parse(Console.ReadLine());
            double result = 1;

           

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day ==  "Friday")
            {
                if (fruit == "banana")
                {
                    result = amount * 2.50;
                }
                else if (fruit == "apple")
                {
                    result = amount * 1.20;
                }
                else if (fruit == "orange")
                {
                    result = amount * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    result = amount * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    result = amount * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    result = amount * 5.50;
                }
                else if (fruit == "grapes")
                {
                    result = amount * 3.85;
                }
            }

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    result = amount * 2.70;
                }
                else if (fruit == "apple")
                {
                    result = amount * 1.25;
                }
                else if (fruit == "orange")
                {
                    result = amount * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    result = amount * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    result = amount * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    result = amount * 5.60;
                }
                else if (fruit == "grapes")
                {
                    result = amount * 4.20;
                }
            }

            if ((!(day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
               day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday")) ||
               (!(fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" ||
               fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:0.00}", result);
            }
            
        }
    }
}
