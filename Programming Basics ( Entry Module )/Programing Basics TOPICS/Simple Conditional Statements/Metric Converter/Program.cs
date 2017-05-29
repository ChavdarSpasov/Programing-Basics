using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            var result = amount;

            if (from == "m")
            {
                result = amount / 1;
            }
            else if (from == "mm")
            {
                result = amount / 1000;
            }
            else if (from == "cm")
            {
                result = amount / 100;
            }
            else if (from == "mi")
            {
                result = amount / 0.000621371192;
            }
            else if (from == "in")
            {
                result = amount / 39.3700787;
            }
            else if (from == "km")
            {
                result = amount / 0.001;
            }
            else if (from == "ft")
            {
                result = amount / 3.2808399;
            }
            else if (from == "yd")
            {
                result = amount / 1.0936133;
            }

            if (to == "m")
            {
                result = result * 1;
                Console.WriteLine(result + " m");
            }
            else if (to == "mm")
            {
                result = result * 1000;
                Console.WriteLine(result + " mm");
            }
            else if (to == "cm")
            {
                result = result * 100;
                Console.WriteLine(result + " cm");
            }
            else if (to == "mi")
            {
                result = result * 0.000621371192;
                Console.WriteLine(result + " mi");
            }
            else if (to == "in")
            {
                result = result * 39.3700787;
                Console.WriteLine(result + " in");
            }
            else if (to == "km")
            {
                result = result * 0.001;
                Console.WriteLine(result + " km");
            }
            else if (to == "ft")
            {
                result = result * 3.2808399;
                Console.WriteLine(result + " ft");
            }
            else if (to == "yd")
            {
                result = result * 1.0936133;
                Console.WriteLine(result + " yd");
            }
        }
    }
}
