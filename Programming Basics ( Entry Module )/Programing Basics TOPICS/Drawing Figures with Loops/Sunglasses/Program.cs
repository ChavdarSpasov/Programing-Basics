using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new String('*', n * 2));
            Console.Write(new String(' ', n));
            Console.Write(new String('*', n * 2));
            Console.WriteLine();
            for (double between = 0; between < n - 2; between++)
            {
                if ((between == (n - 1) / 2 - 1))
                {
                    Console.WriteLine("*" + new String('/', ((n * 5) - 4 - n) / 2) + "*" + new String('|', n) + "*" + new String('/', ((n * 5) - 4 - n) / 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new String('/', ((n * 5) - 4 - n) / 2) + "*" + new String(' ', n) + "*" + new String('/', ((n * 5) - 4 - n) / 2) + "*");
                }






            }

            Console.Write(new String('*', n * 2));
            Console.Write(new String(' ', n));
            Console.Write(new String('*', n * 2));

        }
    }
}
