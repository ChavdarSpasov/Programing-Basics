using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи страна:");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведи височина:");
            var h = decimal.Parse(Console.ReadLine());
            var area = (a * h) / 2;
            Console.WriteLine("Area: {0}", Math.Round(area,2));
        }
    }
}
