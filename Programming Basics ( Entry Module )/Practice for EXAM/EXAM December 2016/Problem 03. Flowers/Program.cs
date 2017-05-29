using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numH = int.Parse(Console.ReadLine()); 
            int numR = int.Parse(Console.ReadLine()); 
            int numL = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double H = 0;
            double R = 0;
            double l = 0;

            switch (season)
            {
                case "spring":
                case "summer":
                    H = numH * 2.00;
                    R = numR * 4.10;     
                    l = numL * 2.50;break;
                case "autumn":
                case "winter":
                    H = numH * 3.75;
                    R = numR * 4.50;
                    l = numL * 4.15; break;
            }

            if (holiday == "y")
            {
                H = H + (H * 0.15);
                R = R + (R * 0.15);
                l = l + (l * 0.15);
            }

            double flowersPrice = H + R + l;

            if (season == "spring" && numL > 7)
            {
                flowersPrice = flowersPrice - (flowersPrice * 0.05);
            }

            if (season == "winter" && numR >= 10)
            {
                flowersPrice = flowersPrice - (flowersPrice * 0.10);
            }

            if ((numH + numL + numR) >20)
            {
                flowersPrice = flowersPrice - (flowersPrice * 0.20);
            }

            flowersPrice = flowersPrice + 2;

            Console.WriteLine("{0:f2}",flowersPrice);


        }
    }
}
