using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var p1 = 0.0; 
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            

            for (int currNum = 0; currNum < n; currNum ++)
            {
                var enteredNum = int.Parse(Console.ReadLine());

                if (enteredNum < 200)
                {
                    p1++;
                }
                else if (enteredNum <= 399)
                {
                    p2++;
                }
                else if (enteredNum <= 599)
                {
                    p3++;
                }
                else if (enteredNum <= 799)
                {
                    p4++;
                }
                else if (enteredNum >= 800)
                {
                    p5++;
                }
                
            }

            var newp1 = p1 / n * 100; 
            var newp2 = p2 / n * 100;
            var newp3 = p3 / n * 100;
            var newp4 = p4 / n * 100;
            var newp5 = p5 / n * 100;

           

            Console.WriteLine("{0:00.00}\n{1:00.00}\n{2:00.00}\n{3:00.00}\n{4:00.00}", newp1,newp2,newp3,newp4,newp5);

        }
    }
}
