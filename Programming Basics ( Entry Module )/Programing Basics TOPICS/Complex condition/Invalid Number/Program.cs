﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (!(number == 0 || (number >= 100 && number <= 200)))  
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
