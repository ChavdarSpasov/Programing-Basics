using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            for (long i = 1; i <= Math.Pow(2,num);i=i*2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
