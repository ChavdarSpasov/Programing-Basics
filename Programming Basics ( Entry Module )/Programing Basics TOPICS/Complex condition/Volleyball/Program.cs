using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearTipe = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double noWork = (3.0 * (48 - weekends)) / 4;
            double holidayPlay = (holidays * 2.0) / 3;
            double playTime = noWork + holidayPlay + weekends;

            if (yearTipe == "leap")
            {
                double lp = (playTime * 0.15);
                var result = playTime + lp;
                Console.WriteLine(Math.Truncate(result));
            }
            else
            {
                Console.WriteLine(Math.Truncate(playTime));
            }
            
                
             
            
        }
    }
}
