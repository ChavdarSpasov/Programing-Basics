using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var num =double.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var evenSum = 0.0;
            
            var evenMaxvolue =double.MinValue;
            var oddMaxvolue = double.MinValue;

            var evenMinvolue = double.MaxValue;
            var oddMinvolue = double.MaxValue;


            for (double currNum = 1; currNum <= num; currNum++)
            {
                var enterNum = double.Parse(Console.ReadLine());

                if (currNum % 2 == 0)
                {
                    evenSum = evenSum + enterNum;
                }
                else if (currNum % 2 != 0)
                {
                oddSum = oddSum + enterNum;
                }

                if (currNum % 2 == 0 && enterNum > evenMaxvolue)
                {
                    evenMaxvolue = enterNum;
                }
                else if (currNum % 2 != 0 && enterNum > oddMaxvolue)
                {
                    oddMaxvolue = enterNum;
                }

                if (currNum % 2 == 0 && enterNum < evenMinvolue)
                {
                    evenMinvolue = enterNum;
                }
                else if (currNum % 2 != 0 && enterNum < oddMinvolue)
                {
                    oddMinvolue = enterNum;
                }
            }


            Console.WriteLine("oddSum = " + oddSum);
            Console.WriteLine((oddMinvolue == double.MaxValue)? "oddMin = No":"oddMin = " + oddMinvolue);
            Console.WriteLine((oddMaxvolue == double.MinValue)? "oddMax = No":"oddMax = " + oddMaxvolue);
            Console.WriteLine("evenSum = " + evenSum);
            Console.WriteLine((evenMinvolue == double.MaxValue)? "evenMin = No":"evenMin = " + evenMinvolue);
            Console.WriteLine((evenMaxvolue == double.MinValue)? "evenMax = No":"evenMax = " + evenMaxvolue);

            

        }
    }
}
