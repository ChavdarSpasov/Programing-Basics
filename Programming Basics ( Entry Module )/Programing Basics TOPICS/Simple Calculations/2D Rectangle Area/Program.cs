using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1:");
            var x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1:");
            var y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2:");
            var x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2:");
            var y2 = double.Parse(Console.ReadLine());
            // var a = Math.Max(y1, y2) - Math.Min(y1,y2);
            //var b = Math.Max(x1, x2) - Math.Min(x1,x2); 
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            Console.WriteLine("Area:{0}", a * b);
            Console.WriteLine("Perimeter:{0}", 2 * (a + b));

        }
    }
}
