using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int leftNum = 0; leftNum < num; leftNum++)
            {
                int numIn = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + numIn;
            }

            for (int rightNum = 0; rightNum < num; rightNum++)
            {
                int numIn = int.Parse(Console.ReadLine());
                sumRight = sumRight + numIn;
            }

            var diff = Math.Abs(sumRight - sumLeft);
            

            if (sumLeft == sumRight)
            {
                Console.WriteLine("yes sum {0}",sumRight);
            }
            else
            {
                Console.WriteLine("no diff {0}", diff);
            }


        }
    }
}
