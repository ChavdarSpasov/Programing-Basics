using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = double.Parse(Console.ReadLine());
            var secondtime = double.Parse(Console.ReadLine());
            var thirdtime = double.Parse(Console.ReadLine());
            double fullTime = firstTime + secondtime + thirdtime;
            double minutes = Math.Truncate(fullTime / 60);
            double seconds = fullTime % 60;
            if (seconds < 10)
            {
                Console.WriteLine("{0}:{1:00}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}
