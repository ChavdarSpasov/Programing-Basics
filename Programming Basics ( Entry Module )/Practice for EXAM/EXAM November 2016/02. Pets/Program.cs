using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysAway = int.Parse(Console.ReadLine());
            var foodLeft = int.Parse(Console.ReadLine());
            var foodforDOGperdayinkilos = double.Parse(Console.ReadLine());
            var foodforCATperdayinkilos = double.Parse(Console.ReadLine());
            var foodforTURTLEperdayingrams = double.Parse(Console.ReadLine());

            double dogFood = foodforDOGperdayinkilos * daysAway;
            double catFood = foodforCATperdayinkilos * daysAway;
            double turtleFood = foodforTURTLEperdayingrams * daysAway / 1000;

            double allFood = dogFood + catFood + turtleFood;


            if (foodLeft>allFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(foodLeft - allFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allFood - foodLeft));
            }


        }
    }
}
