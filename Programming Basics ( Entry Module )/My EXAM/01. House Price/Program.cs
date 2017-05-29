using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());          
            var pricePI = double.Parse(Console.ReadLine());

            var bathRoomArea = smallestRoomArea / 2;
            var secondRoomArea = (smallestRoomArea * 0.10) + smallestRoomArea;
            var thirdRoomArea = (secondRoomArea * 0.10) + secondRoomArea;


            double roomsArea = smallestRoomArea + kitchenArea + secondRoomArea + bathRoomArea + thirdRoomArea;
            double hallwaay = roomsArea * 0.05;

            double allArea = roomsArea + hallwaay;
            double priceApartment = pricePI * allArea;

            Console.WriteLine("{0:f2}",priceApartment); 






        }
    }
}
