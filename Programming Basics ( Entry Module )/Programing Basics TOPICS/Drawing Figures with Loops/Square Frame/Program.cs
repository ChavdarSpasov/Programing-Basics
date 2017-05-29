using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var num =int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int topR = 0; topR < num - 2; topR++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
            
            for (int bodyRow = 0; bodyRow < num - 2 ; bodyRow++)
            {
                Console.Write("|");
                for (int innerBody = 0; innerBody < num -2; innerBody++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int topR = 0; topR < num - 2; topR++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();












        }

    }
}
