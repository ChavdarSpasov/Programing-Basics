using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieType = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var places = rows * columns;
            var result1 = places * 5.00;
            var result2 = places * 7.50;
            var result3 = places * 12.00;
            switch (movieType)
            {
                case "Discount": Console.WriteLine("{0:f2}",result1); break;
                case "Normal": Console.WriteLine("{0:f2}", result2);break;
                case "Premiere": Console.WriteLine("{0:f2}", result3);break;
            }

          
        }
    }
}
