using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_HARVEST
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = int.Parse(Console.ReadLine());
            var vineQM = double.Parse(Console.ReadLine());
            var vineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var vineyardQM = vineyard * vineQM;
            var vineProduction = (vineyardQM * 40 / 100)/2.5;

            if (vineProduction < vineNeeded)
            {
                var rest = Math.Floor(vineNeeded - vineProduction);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", rest);
            }
            else
            {
                var rest = vineProduction - vineNeeded;
                var vinePerPerson = rest / workers;
                Console.WriteLine("Good harvest this year!Total wine: {0} liters.",Math.Floor(vineProduction));
                Console.WriteLine("{0} liters left -> {1} liters per person.",rest,vinePerPerson);
            }
        }
    }
}
