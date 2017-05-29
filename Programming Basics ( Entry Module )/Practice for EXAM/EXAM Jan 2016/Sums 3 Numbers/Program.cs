using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
         {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c =int.Parse(Console.ReadLine());

            
            var newa = Math.Min(a, b);
            var newb = Math.Max(a, b);
            a = newa;
            b = newb;
            if (c > b)
            {
                
                if (a+b==c)
                {
                    Console.WriteLine("{0}+{1}={2}",a,b,c);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                
                if (a+c==b)
                {
                    
                    Console.WriteLine("{0}+{1}={2}",Math.Min(a,c),Math.Max(a,c),b);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}
