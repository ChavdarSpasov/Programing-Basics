using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Въведи N:");
                var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
                var a = new string('*',n);
                var b = new string(' ',n-2);
            Console.WriteLine(a);
              for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                Console.Write(b);
                Console.WriteLine("*");
            }
            Console.WriteLine(a);
            Console.WriteLine();
        }
    }
}  
