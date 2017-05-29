using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var emptyspaces = n-1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ',emptyspaces));
                Console.Write("*");
                for (int col = 0; col < row-1; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
                emptyspaces--;
            }

            emptyspaces = 1;

            for (int row = n-1; row >= 1; row--)
            {
                Console.Write(new string(' ', emptyspaces));
                Console.Write("*");
                for (int col = row-1; col > 0; col--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
                emptyspaces++;
            }
        }
    }
}
