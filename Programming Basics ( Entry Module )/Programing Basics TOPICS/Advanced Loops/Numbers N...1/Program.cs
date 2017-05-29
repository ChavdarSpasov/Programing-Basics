using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_N._._._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  var num = int.Parse(Console.ReadLine());

              while (num>=1)
              {

                  Console.WriteLine(num);
                  num--;
              }*/


            var num = int.Parse(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
