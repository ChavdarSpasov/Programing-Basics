using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {
                Console.Write("$");
                for (int currRow = 0; currRow < row ; currRow++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }



        }
    }
}
