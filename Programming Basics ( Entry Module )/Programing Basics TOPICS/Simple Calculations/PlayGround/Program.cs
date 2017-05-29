using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var playgroundSide = double.Parse(Console.ReadLine());
            var hplate = double.Parse(Console.ReadLine());
            var lplate = double.Parse(Console.ReadLine());
            var hbench = double.Parse(Console.ReadLine());
            var lbench = double.Parse(Console.ReadLine());

            var playgroundS = playgroundSide * playgroundSide;
            var plateS = hplate * lplate;
            var benchS = hbench * lbench;
            var plateNumber = (playgroundS - benchS) / plateS;
            var timeofwork = plateNumber * 0.2;
            Console.WriteLine("{0}\n{1}", plateNumber, timeofwork);

        }
    }
}
