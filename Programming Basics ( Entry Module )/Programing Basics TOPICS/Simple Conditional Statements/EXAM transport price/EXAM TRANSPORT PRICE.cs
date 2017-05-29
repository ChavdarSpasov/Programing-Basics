using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string daynight = Console.ReadLine();
            

            if (distance < 20 && daynight == "day" )
            {
                var dayPrice = 0.70 + (0.79 * distance);
                Console.WriteLine(dayPrice);
            }
            else if (distance < 20 && daynight == "night" )
            {
                var nightPrice = 0.70 + (0.90 * distance);
                Console.WriteLine(nightPrice);
            }
            if (distance > 20 && distance <= 100 && daynight == "day"  )
            {
                var dayPrice = 0.09 * distance;
                Console.WriteLine(dayPrice);
            }
            if (distance > 20 && distance <= 100 && daynight == "night"  )
            {
                var nightPrice = 0.90 * distance;
                Console.WriteLine(nightPrice);
            }
            if (distance >= 100 && daynight == "day")
            {
                var dayPrice1 = 0.06 * distance;
                var dayPrice2 = 0.70 + (0.79 * distance);
                Console.WriteLine((dayPrice1 < dayPrice2)? dayPrice1:dayPrice2);
            }
            else if (distance >= 100 && daynight == "night")
            {
                var nightPrice1 = 0.06 * distance;
                var nightPrice2 = 0.70 + (0.90 * distance);
                Console.WriteLine((nightPrice1 < nightPrice2)? nightPrice1:nightPrice2);
            }
        }
    }
}
