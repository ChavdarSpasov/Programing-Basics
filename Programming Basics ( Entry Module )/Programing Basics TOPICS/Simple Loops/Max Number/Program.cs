using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numtocount = int.Parse(Console.ReadLine());
            var minnum = int.MinValue;

            

            for (int currnum = 0; currnum < numtocount; currnum++)
            {

                var num = int.Parse(Console.ReadLine());

                if (minnum < num )
                {
                    minnum = num;
                }


            }

            Console.WriteLine(minnum);

        }
    }
}
