﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var minArea = int.Parse(Console.ReadLine());

            if ((n - (n * - 1) * (n - (n * -1) )< minArea))
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int x1 = n * -1; x1 <= n; x1++)
                {
                    for (int y1 = n * -1; y1 <= n; y1++)
                    {
                        for (int x2 = x1; x2 <= n; x2++)
                        {
                            for (int y2 = y1; y2 <= n; y2++)
                            {

                                var area = (x2 - x1) * (y2 - y1);

                                if (area >= minArea)
                                {

                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                    x1, y1, x2, y2, area);
                                }


                            }
                        }
                    }
                }
            }

              
        }
    }
}
