﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());
            var num =1;
                for (int i = 1; i <= n; i++)
                {
                
                    for (int j = 0; j < i; j++)
                    {
                    
                        Console.Write(num + " ");
                        num++;
                    
                    
                    if (num > n)
                    {
                        break;
                    }

                    }
                    Console.WriteLine();

                if (num > n)
                {
                    break;
                }

            }

            
        }
    }
}
