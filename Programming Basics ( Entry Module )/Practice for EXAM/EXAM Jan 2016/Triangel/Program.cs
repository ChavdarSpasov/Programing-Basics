﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangel
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 =int.Parse(Console.ReadLine());
            var y1 =int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            double a = Math.Abs(x2 - x3);
            double h = Math.Abs(y1 - y2);


            double s = a * h / 2;

            Console.WriteLine("{0}",s);
        }
    }
}
