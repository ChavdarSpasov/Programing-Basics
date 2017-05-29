using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_POOL_TUBES
{
    class Program
    {
        static void Main(string[] args)
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var tube1 = int.Parse(Console.ReadLine());
            var tube2 = int.Parse(Console.ReadLine());
            var timeout = double.Parse(Console.ReadLine());
            var tube1Power = tube1 * timeout;
            var tube2Power = tube2 * timeout;
            var combinePower = tube1Power + tube2Power;
            if (combinePower > poolVolume)
            {
                var extra = combinePower - poolVolume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", timeout, extra);
            }
            if (combinePower < poolVolume)
            {
                var poolRate = (combinePower / poolVolume) *100;
                var tube1rate = (tube1Power / poolRate) *10;
                var tube2rate = (tube2Power / poolRate) * 10;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",poolRate,Math.Truncate(tube1rate),Math.Truncate(tube2rate));
            
            }

            
        }
    }
}
