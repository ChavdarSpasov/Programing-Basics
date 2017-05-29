using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_partition_without_residue
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int currNum = 0; currNum < num; currNum++)
            {
                var enteredNumber = int.Parse(Console.ReadLine());

                if (enteredNumber % 2 == 0)
                {
                    p1++;
                }
                if (enteredNumber % 3 == 0)
                {
                    p2++;
                }
                if (enteredNumber % 4 == 0)
                {
                    p3++;
                }
            }

            double newp1 = (p1 / num) * 100;
            double newp2 = (p2 / num) * 100;
            double newp3 = (p3 / num) * 100;


            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%",newp1,newp2,newp3);

        }
    }
}
