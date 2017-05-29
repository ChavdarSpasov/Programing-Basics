using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            /*for (int i = 1; i <= n; i=i*2+1)
            {
                Console.WriteLine(i);
            }*/

            /* int num=1;
             do
             {
                 Console.WriteLine(num);
                 num = 2 * num + 1;

             } while (num<=n);*/

            int num = 1;
            while (num<=n)
            {
                Console.WriteLine( num);
                num = num * 2 + 1;
            }
        }
    }
}
