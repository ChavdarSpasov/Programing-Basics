using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            var num =int.Parse(Console.ReadLine());
              var sum = 0;
              do
              {
                  var newnum = num % 10;
                  sum = sum + newnum;
                  num = num / 10;

              } while (num!=0);

              Console.WriteLine(sum);
            

        }
        
    }
}
