using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVAuction
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceV = double.Parse(Console.ReadLine());
            var priceF = double.Parse(Console.ReadLine());
            var kgV = int.Parse(Console.ReadLine());
            var kgF = int.Parse(Console.ReadLine());

            var moneyV = priceV * kgV;
            var moneyF = priceF * kgF;
            var allMoney = (moneyV + moneyF) / 1.94;
            Console.WriteLine(allMoney);




        }
    }
}
