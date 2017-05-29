using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorHigh = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double sideofTriangle = double.Parse(Console.ReadLine());
            double highofTriangle = double.Parse(Console.ReadLine());
            double priceoofPlate = double.Parse(Console.ReadLine());
            double moneyforMaster = double.Parse(Console.ReadLine());

            double areaPlate = sideofTriangle * highofTriangle / 2;
            double areaFloor = floorHigh * floorLength;
            double numberPlates = Math.Ceiling(areaFloor / areaPlate) + 5 ;
            double moneyforPlates = numberPlates * priceoofPlate;
            double totalMoney = moneyforPlates + moneyforMaster;

            if (savedMoney>=totalMoney)
            {
                double moneyLeft = savedMoney - totalMoney;

                Console.WriteLine("{0:f2} lv left.",moneyLeft);
            }
            else
            {
                double moneyNeeded = totalMoney - savedMoney;

                Console.WriteLine("You'll need {0:f2} lv more.", moneyNeeded);
            }
        }
    }
}
