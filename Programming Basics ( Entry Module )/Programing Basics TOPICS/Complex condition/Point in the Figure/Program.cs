using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double x1 = 0;
            double y1 = 0;
            double x2 = 3 * h;
            double y2 = h;

            double x11 = h;
            double y11 = h;
            double x22 = 2 * h;
            double y22 = 4 * h;

            var rectangel1in = (x > x1 && x < x2) && (y > y1 && y < y2);
            var rectangel2in = (x > x11 && x < x22) && (y > y11 && y < y22);
            
            var rectangel1out = (x < x1 && x > x2) && (y < y1 && y > y2);
            var rectangel2out = (x < x1 && x > x2) && (y < y1 && y > y2);

            var rectBorder1 = ((x == x1 || x == x2) && (y >= y1 && y <= y2))
                              && ((y == y1 || y == y2) && (x >= x1 && x <= x2));
            var rectBorder2 = ((x == x11 || x == x22)&& (y >= y11 && y <= y22))
                              && ((y == y11 || y == y22) && (x >= x11 && x <= x22)); 
            
            if (rectangel1in || rectangel2in)
            {
                Console.WriteLine("inside");
            }
             else if (rectangel1out || rectangel2out)
            {
                Console.WriteLine("out");
            }
            else if( rectBorder1 || rectBorder2)
            {
                Console.WriteLine("border");
            }
            
        }
    }
}
