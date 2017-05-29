using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            hours = hours * 60;
            int allmin = hours + minutes + 15;
            int newHours = allmin / 60;
            int newMinutes = allmin % 60;
            if (newHours > 23 && newHours < 25)
            {
                Console.WriteLine("0:{0:00}", newMinutes);
            }
            else

            Console.WriteLine("{0:0}:{1:00}", newHours, newMinutes);

        }
    }
}    