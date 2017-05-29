using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOftrakLoads = int.Parse(Console.ReadLine());

            int tonsPerload = 0;
            double priceTonloads = 0;
            double avaragePriceperTonload = 0.0;
            double percentPerloadbyBus = 0;
            double percentPerloadbyTrack = 0;
            double percentPerloadbyTrain = 0;


            for (int i = 0; i < numberOftrakLoads; i++)
            {
                var currLoads = int.Parse(Console.ReadLine());

                if (currLoads <= 3)
                {
                    tonsPerload += currLoads;
                    priceTonloads += currLoads * 200;
                    percentPerloadbyBus += currLoads;
                }
                else if (currLoads <= 11)
                {
                    tonsPerload += currLoads;
                    priceTonloads += currLoads * 175;
                    percentPerloadbyTrack += currLoads;
                }
                else
                {
                    tonsPerload += currLoads;
                    priceTonloads += currLoads * 120;
                    percentPerloadbyTrain += currLoads;
                }
            }

            avaragePriceperTonload = priceTonloads / tonsPerload;

            Console.WriteLine("{0:f2}",avaragePriceperTonload);
            Console.WriteLine("{0:f2}%",percentPerloadbyBus/tonsPerload*100);
            Console.WriteLine("{0:f2}%",percentPerloadbyTrack/tonsPerload*100);
            Console.WriteLine("{0:f2}%",percentPerloadbyTrain/tonsPerload*100);

        }
    }
}
