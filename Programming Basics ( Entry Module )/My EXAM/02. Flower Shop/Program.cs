using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            var m = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var r = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var priceGift = double.Parse(Console.ReadLine());

            double priceM = 3.25 * m;
            double priceZ = 4 * z;
            double priceR= 3.50 * r;
            double priceK = 8 * k;


            var priceFlowers = priceK + priceM + priceR + priceZ;
            var taxes = priceFlowers * 0.05;

            var endPrice = priceFlowers - taxes;


            if (priceGift>endPrice)
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(priceGift - endPrice));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(endPrice - priceGift));
            }
            

        }
    }
}
