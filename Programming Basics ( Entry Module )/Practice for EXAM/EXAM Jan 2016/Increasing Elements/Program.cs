using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var n = int.Parse(Console.ReadLine());

             
            var biggerCol = 0;
            var col = 0;

            var currNum = -1000;
            for (int i = 0; i < n; i++)
            {
                var nextNum = int.Parse(Console.ReadLine());
                
                if (nextNum>currNum)
                {
                    col++;
                    
                }
                else
                {
                    col = 1;
                }
                if (col > biggerCol)
                {
                    biggerCol = col;
                }

                currNum = nextNum;

            }

            Console.WriteLine(biggerCol);
        }
    }
}
 