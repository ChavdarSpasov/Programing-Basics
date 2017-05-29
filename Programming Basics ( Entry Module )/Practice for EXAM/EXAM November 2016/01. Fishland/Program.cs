using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceforMackerel = double.Parse(Console.ReadLine());         //skumriq
            var priceforspratSprat = double.Parse(Console.ReadLine());          //caca      
            var kilosofBeltedbonito = double.Parse(Console.ReadLine());            //palamud    
            var kilosofSkad = double.Parse(Console.ReadLine());                         //safrid
            var kilosofClams = int.Parse(Console.ReadLine());                               //midi

            double priceforClams = kilosofClams * 7.50;
            double priceforSkad = ((priceforspratSprat * 0.80) + priceforspratSprat) * kilosofSkad ;
            double priceforBeltedbonito = ((priceforMackerel * 0.60) + priceforMackerel) * kilosofBeltedbonito;

            double totalPrice = priceforBeltedbonito + priceforSkad + priceforClams;

            Console.WriteLine("{0:f2}",totalPrice);
        }
    }
}
