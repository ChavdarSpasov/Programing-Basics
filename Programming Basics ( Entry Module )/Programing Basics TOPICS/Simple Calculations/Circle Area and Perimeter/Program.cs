using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Въведи радидус:");//
            var r = double.Parse(Console.ReadLine());
            double Perimeter = 2 * Math.PI * r;
            double Area = Math.PI * r * r;
            Console.WriteLine( Math.Round(Area,4));
            Console.WriteLine(Math.Round(Perimeter,4));
            
           
        }
    }
}
