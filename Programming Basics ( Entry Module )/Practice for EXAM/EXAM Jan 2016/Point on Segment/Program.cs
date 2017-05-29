using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var firs = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());


            var newFirst = Math.Min(firs, second);
            var newSecond = Math.Max(firs, second);

            if (point>=newFirst&&point<=newSecond)
            {
                var closerTofirst = Math.Abs(point - newFirst);
                var closerTosecond = Math.Abs(point  - newSecond);

                if (closerTofirst<closerTosecond)
                {
                    Console.WriteLine("in\n{0}",closerTofirst);
                }
                else
                {
                    Console.WriteLine("in\n{0}",closerTosecond);
                }

            }
            else
            {
                if (point>newSecond)
                {
                    Console.WriteLine("out\n{0}", Math.Abs(point-newSecond));
                }
                else
                {
                    Console.WriteLine("out\n{0}", Math.Abs(point-newFirst));
                }
            }


        }
    }
}
