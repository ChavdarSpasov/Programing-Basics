using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            for (long i = 1; i <= Math.Pow(2,num); i=i*4)
            {
                Console.WriteLine(i);
            }
        }
    }
}
