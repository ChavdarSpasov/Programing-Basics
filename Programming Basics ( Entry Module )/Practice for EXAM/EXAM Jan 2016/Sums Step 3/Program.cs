﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;


            for (int i = 1; i <= n; i++)
            {
                var currNum =int.Parse(Console.ReadLine());

                if (i % 3 == 1)
                {
                    sum1 = sum1 + currNum;
                }
                if (i % 3 == 2)
                {
                    sum2 = sum2 + currNum;
                }
                if (i % 3 == 0)
                {
                    sum3 = sum3 + currNum;
                }

                
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);


        }
    }
}
