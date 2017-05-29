using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {


                if (n % 2 == 0)
                {
                    Console.WriteLine(new String('-', (n - 1) / 2) + "**" + new String('-', (n - 1) / 2));
                }
                else
                {
                    Console.WriteLine(new String('-', (n - 1) / 2) + "*" + new String('-', (n - 1) / 2));
                }

                var sidePadding = (n - 1) / 2;
                var innerPadding = 0;
                if (n % 2 == 0)
                {
                    innerPadding = 2;
                }
                else
                {
                    innerPadding = 1;
                }
                for (int row = 0; row < ((n + 1) / 2) - 1; row++)
                {
                    Console.Write(new String('-', sidePadding - 1));
                    Console.Write("*" + new String('-', innerPadding) + "*");
                    Console.WriteLine(new String('-', sidePadding - 1));
                    sidePadding -= 1;
                    innerPadding += 2;

                }
                var dSidepadding = 1;
                var dInnerpadding = n - 4;
                for (int dR = 0; dR < (n + 1) / 2 - 2; dR++)
                {
                    Console.Write(new String('-', dSidepadding));
                    Console.Write("*" + new String('-', dInnerpadding) + "*");
                    Console.WriteLine(new String('-', dSidepadding));
                    dSidepadding += 1;
                    dInnerpadding -= 2;
                }
                if (n % 2 == 0)
                {
                    Console.WriteLine(new String('-', (n - 1) / 2) + "**" + new String('-', (n - 1) / 2));
                }
                else
                {
                    Console.WriteLine(new String('-', (n - 1) / 2) + "*" + new String('-', (n - 1) / 2));
                }

            }

        }
    }
}
