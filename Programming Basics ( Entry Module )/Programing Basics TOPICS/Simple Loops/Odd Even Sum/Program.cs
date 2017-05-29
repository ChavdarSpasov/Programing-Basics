using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var odd = 0;
            var even = 0; 
            for (int counter = 1; counter <= n; counter++)
            {
                var numIn = int.Parse(Console.ReadLine());

                if (counter % 2 != 0)
                {
                    odd = odd + numIn;
                }
                else
                {
                    even = even + numIn;
                }

                
            }
            var diff = Math.Abs(odd - even);
            Console.WriteLine((odd == even)? "Yes Sum = "+ odd:"No Diff = "+ diff);
        }

    }
}
