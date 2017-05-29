using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (int currRow = 0; currRow < size; currRow++)
            {

                    Console.Write("*");
                for (int innerRow = 0; innerRow < size - 1 ; innerRow++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                  
                    
                }
                Console.WriteLine();
            }

        }
    }
}
