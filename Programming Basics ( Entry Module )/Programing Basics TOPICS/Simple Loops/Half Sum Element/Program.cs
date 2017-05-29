using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNumber = int.MinValue;

            for (int currNum = 0; currNum < num; currNum++)
            {
                var enterNum = int.Parse(Console.ReadLine());
                sum = sum + enterNum;

                if (enterNum > maxNumber)
                {
                    maxNumber = enterNum;
                }

            }

            if (maxNumber == (sum - maxNumber))
            {
                Console.WriteLine("Yes\nSum = {0}",maxNumber);
            }
            else 
            {
                var diff = Math.Abs(maxNumber - (sum - maxNumber));
                Console.WriteLine("No\nDiff = {0}", diff);
            }


        }
    }
}
