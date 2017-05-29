using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            var f0 = 1;
            var f1 = 1;

           
            for (int i = 0; i < n-1; i++)
            {
                var fLast = f0 + f1;
                f0 = f1;
                f1 = fLast;
            }
            if (n<2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(f1);
            }
        }
    }
}
