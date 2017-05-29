using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int sOne = 1; sOne <= n; sOne++)
            {
                for (int sTwo = 1; sTwo <= n; sTwo++)
                {
                    for (char sThree = 'a'; sThree < 'a' + l; sThree++)
                    {
                        for (char sFour = 'a'; sFour < 'a' + l; sFour++)
                        {
                            for (int sFive = Math.Max(sOne, sTwo)+1; sFive <=n; sFive++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",sOne,sTwo,sThree,sFour,sFive);
                            }
        
                        }
                    }
                }
            }
        }
    }
}
