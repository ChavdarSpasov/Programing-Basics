using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //  Console.WriteLine(new string('*', i));
            //}
            for (int i = 0; i <=11 ; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
