﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double bonus = 0;
            double extraBonus = 0;
            if (num <= 100)
            {
                bonus += 5;
            }
            else if (num <= 1000)
            {
                bonus += num * 0.2;
            }
            else if (num > 1000)
            {
                bonus = num * 0.1;
            }
            if (num % 2 == 0)
            {
                extraBonus= extraBonus + 1;
            }
            if (num % 10 == 5)
            {
                extraBonus = extraBonus + 2;
            }
            Console.WriteLine(bonus + extraBonus);
            Console.WriteLine(num + bonus + extraBonus);

        }
    }
}
