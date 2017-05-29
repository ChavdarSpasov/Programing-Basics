using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var dig3 = num % 10;
            var dig2 = (num / 10) % 10;
            var dig1 = num / 100;
            var row = dig1 + dig2;
            var col = dig1 + dig3;
             

            var newNumber = num;

            for (int currRow = 0; currRow < row; currRow++)
            {

                for (int currCol = 0; currCol < col; currCol++)
                {
                    if (newNumber % 5 == 0)
                    {
                        newNumber = newNumber - dig1;
                    }
                    else if (newNumber % 3 == 0)
                    {
                        newNumber = newNumber - dig2;
                    }
                    else 
                    {
                        newNumber = newNumber + dig3;
                    }

                    Console.Write("{0} ",newNumber);

                }
                Console.WriteLine();

            }

        }
    }
}
