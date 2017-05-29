using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endinterval = int.Parse(Console.ReadLine());
            int maxNumberCombinatins = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startInterval; i <= endinterval; i++)
            {
                for (int j = startInterval; j <= endinterval; j++)
                {
                    sum++;

                    Console.Write("<{0}-{1}>",i,j);

                    if (sum == maxNumberCombinatins)
                    {
                        break;
                    }
                }

                if (sum == maxNumberCombinatins)
                {
                    break;
                }
            }
        }
    }
}
