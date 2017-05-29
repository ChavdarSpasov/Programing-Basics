using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Letters_Comb
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());
            int num = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != simbol && j != simbol && k != simbol)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            num++;
                        }
                       
                    }
                }
            }

            Console.Write(num);


        }
    }
}
