using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe_28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lenght = 5 * n;
            var heigth = lenght;
            var fistDashes = new string('-', 3 * n);
            Console.WriteLine("{0}{1}{2}", fistDashes, 
                new string('*', 2), new string('-', (lenght - (3 * n) - 2)));
            for (int i = 1; i < n; i++)
            {
                
                Console.Write(fistDashes);
                Console.Write("*{0}*", new string('-',i));
                Console.Write(new string('-',lenght-3*n-2-i));
                Console.WriteLine();


            }
            for (int j = 0; j < n/2; j++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('*',3*n),
                    new string('-',n-1),new string ('-',n-1));
            }

            if (n>3)
            {
                for (int l = 0; l <= n / 2-1; l++)
                {
                    if (l == n / 2-1)
                    {
                        Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - l),
                        new string('*', (n - 1) + l * 2), new string('-', n - 1 - l));
                        break;
                    }
                    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - l),
                        new string('-', (n - 1) + l * 2), new string('-', n - 1 - l));

                }
            }

            else
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n),
                    new string('*', n - 1), new string('-', n - 1));
            }
        }
           
        }
    }

