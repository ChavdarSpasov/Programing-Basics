using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var num =int.Parse(Console.ReadLine());
             var fact = 1;
             for (int i = 1; i <=num; i++)
             {

                 fact = fact * i;
             }
             Console.WriteLine(fact);

            var number = int.Parse(Console.ReadLine());
            var count = 1;
            var fact = 1;
            while (count <= number)
            {
                fact = fact * count;
                count++;
            }
            Console.WriteLine(fact);*/
            var n =int.Parse(Console.ReadLine());
            var fact = 1;
            do
            {
                fact = fact * n;
                n--;
            } while (n>1);

            Console.WriteLine(fact);

        }
    }
}
