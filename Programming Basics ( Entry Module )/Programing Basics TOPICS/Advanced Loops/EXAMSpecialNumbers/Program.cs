using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            if ((n % i) == 0 && (n % j) == 0
                                && (n % k) == 0 && (n % l) == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ",
                                    i, j, k, l);
                                  

                            }
                        }
                    }
                }
            }
        }
    }
}
