using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Въведи N:");
            var n = int.Parse(Console.ReadLine());
            // Console.WriteLine();
            //var = new string('*', n);
            //var b = new string(' ', n - 2);
            //Console.WriteLine(a);
            //for (int i = 0; i < n - 2; i++)
            //{
            //Console.Write("*");
            //Console.Write(b);
            //  Console.WriteLine("*");
            //}
            //Console.WriteLine(a);
            //Console.WriteLine();
            for (int l = 0; l < n; l++)
            {
                Console.Write("*");
            }          
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= n-(n-1); j++)
                {
                    Console.Write("*");
                    for (int k = 0; k < n-2; k++)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            for (int m = 0; m < n; m++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
