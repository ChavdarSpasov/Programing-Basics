using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_SLEEPY_CAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDay = int.Parse(Console.ReadLine());
            var restDayMin =restDay * 127; 
            var playDayMin = (365 - restDay) * 63;
            var allTimeMin = restDayMin + playDayMin;
            if (allTimeMin > 30000)
            {
                Console.WriteLine("Tom will run away");
                var formDifference = allTimeMin - 30000;
                var hours = formDifference / 60;
                var min = formDifference % 60; 
                Console.WriteLine("{0} hours and {1:00} minutes more for play", hours, min) ;
            }
            else if (allTimeMin < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                var formDifference = 30000 - allTimeMin;
                var hours = formDifference / 60;
                var min = formDifference % 60;
                Console.WriteLine("{0} hours and {1:00} minutes less for play", hours, min);
            }


        }
    }
}