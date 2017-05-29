using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_travel
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (money <= 100) //bugaria
            {
                if (season == "summer")
                {
                    var campPrice = (money * 0.3);

                    Console.WriteLine("Samewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}",campPrice);
                }
                else
                {
                    var hotelPrice = (money * 0.7);

                    Console.WriteLine("Samewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", hotelPrice);
                }
            }
            else if (money <= 1000) // balcans
            {
                if (season == "summer")
                {
                    var campPrice = (money * 0.4);

                    Console.WriteLine("Samewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", campPrice);
                }
                else
                {
                    var hotelPrice = (money * 0.8);

                    Console.WriteLine("Samewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", hotelPrice);
                }
            }
            else 
            {

                var hotelPrice = (money * 0.9);

                Console.WriteLine("Samewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", hotelPrice);
            }
        }

    }
}
