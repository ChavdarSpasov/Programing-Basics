using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM__CLASSROOM_
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            h = h * 100;
            w = w * 100;
            var deskRow = Math.Truncate(h / 120);
            var deskCol = Math.Truncate((w-100) / 70);
            var allDesks = (deskCol * deskRow) - 3;
            Console.WriteLine(allDesks);
        }
    }
}
