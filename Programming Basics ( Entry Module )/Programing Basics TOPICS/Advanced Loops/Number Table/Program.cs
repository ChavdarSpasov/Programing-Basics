using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num =int.Parse(Console.ReadLine());

            
            for (int row = 1; row <= num; row++)
            {
                for (int leftcol = row; leftcol <= num; leftcol++)
                {

                    Console.Write(leftcol + " ");

                }

                var n = num;

                for (int i = 1; i < row; i++)
                {
                    n--;
                    Console.Write(n + " ");
                    
                   
                   
                    
              
                   
                }
                Console.WriteLine();
            }
        }
    }
}
