using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Console.Write("Enter a number in the range[1...100]:");

              for (int i = 0;; i++)
              {
              var n = int.Parse(Console.ReadLine());

                  if (n<1 || n>100)
                  {
                      Console.WriteLine("Invalid number!");
                  }
                  else
                  {
                      Console.WriteLine("The number is:"+n);
                      break;
                  }
              }*/


            Console.Write("Еnter a number in the range [1...100]:" );
            var num = int.Parse(Console.ReadLine());  
            while (num<1||num>100)
            {
                Console.WriteLine("Invalid number");
                
                Console.Write("Еnter a number in the range[1...100]:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: " + num);
        }
    }
}
