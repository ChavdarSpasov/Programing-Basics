using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_December_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingSpeeddesdrivedlenght = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double speedOne = startingSpeeddesdrivedlenght;
            double speedTwo = speedOne + (speedOne * 0.10);
            double speedThree = speedTwo - (speedTwo * 0.05);

            double minOne = firstTime / 60.0;
            double minTwo = secondTime / 60.0;
            double minThree = thirdTime / 60.0;

            double lengthOne = speedOne * minOne;
            double lengthTwo = speedTwo * minTwo;
            double lengthThree = speedThree * minThree;
            double totalKilometers = lengthOne + lengthTwo + lengthThree;

            Console.WriteLine("{0:f2}", totalKilometers);
                

        }
    }
}
