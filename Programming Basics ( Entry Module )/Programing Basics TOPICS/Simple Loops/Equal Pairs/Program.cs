using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            var numOfdoubles = int.Parse(Console.ReadLine());

            var realSum = 0;
            var diff = 0;
            for (int firstCounter = 0; firstCounter < numOfdoubles; firstCounter++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var sum = num1 + num2;
                
                

                if (firstCounter > 0 && sum == realSum)
                {

                    realSum = sum ;
                }
                else if (firstCounter > 0 && sum != realSum)
                {
                    diff = realSum - sum;
                }

                realSum = sum;
            }
            if (diff == 0)
            {
                Console.WriteLine("Yes, value = " + (realSum));
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + Math.Abs(diff));
            }
            
        }
    }
}
