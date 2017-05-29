using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            var jBikers = int.Parse(Console.ReadLine());
            var sBikers = int.Parse(Console.ReadLine());
            string ground = Console.ReadLine();

            var jPrice = 0.0;
            var sPrice = 0.0;
            var allPrice = 0.0;


            switch (ground)
            {
                case "trail":
                    jPrice = jBikers * 5.50;
                    sPrice = sBikers * 7;
                    allPrice = jPrice + sPrice;
                    break;

                case "cross-country":
                    jPrice = jBikers * 8;
                    sPrice = sBikers * 9.50;
                    allPrice = jPrice + sPrice;

                    if (jBikers + sBikers >= 50)
                    {
                        jPrice = jBikers * 8;
                        sPrice = sBikers * 9.50;
                        allPrice = jPrice + sPrice;
                        var priceOff = allPrice * 0.25; 
                        allPrice -= priceOff;
                    }

                    break;

                case "downhill":
                    jPrice = jBikers * 12.25;
                    sPrice = sBikers * 13.75;
                    allPrice = jPrice + sPrice;
                    break;

                case "road":
                    jPrice = jBikers * 20;
                    sPrice = sBikers * 21.50;
                    allPrice = jPrice + sPrice;
                    break;
            }


            double taxes = allPrice * 0.05;
            double endPrice = allPrice - taxes;


            Console.WriteLine("{0:f2}",endPrice);

        }
    }
}
