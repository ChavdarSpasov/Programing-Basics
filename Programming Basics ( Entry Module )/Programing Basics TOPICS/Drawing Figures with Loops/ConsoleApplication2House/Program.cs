using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n%2 == 0)
            {
                stars++;
            }
            for (int i = 0; i < (n+1)/2; i++)
            {
                var padding = (n - stars) / 2;
                
                Console.Write(new String('-',padding));
                Console.Write(new String('*', stars));
                Console.WriteLine(new String('-', padding));
                stars += 2;
            }
            for (int j = 0; j < (n/2); j++)
            {
                Console.Write("|");
                Console.Write(new String('*',n-2));
                Console.WriteLine("|");
            }
            
            
        }
    }
}
