using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (Math.Max(a, b) - Math.Min(a, b) < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    
                    for (int j = a; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int l = a; l <= b; l++)
                            {

                                if(i<j && j<k && k<l)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);

                                }
                               
                               
                            }
                        }
                    }
                }
            }


           

        }
    }
}
