using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var battleCounter = 0;

            for (int i = 1; i <= p1; i++)
            {
                for (int j = 1; j <= p2; j++)
                {
                    Console.Write("({0} <-> {1})",i,j);

                    battleCounter++;


                    if (battleCounter>=maxBattles)
                    {
                        break;
                    }
                }


                if (battleCounter >= maxBattles)
                {
                    break;
                }

            }


        }
    }
}
