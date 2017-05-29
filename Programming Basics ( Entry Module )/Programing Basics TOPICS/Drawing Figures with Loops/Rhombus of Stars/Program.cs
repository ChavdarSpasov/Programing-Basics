using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
               var num = int.Parse(Console.ReadLine());
            
               for (int uprow = 1; uprow <= num; uprow++)
               {
                   Console.Write(new String(' ',num - uprow));

                   for (int i = 0; i < uprow; i++)
                   {
                       Console.Write("* ");

                   }
                   Console.WriteLine();                               
               }
               for (int downrow = 0; downrow < num-1 ; downrow++)
               {
                   Console.Write(new String(' ',(num -(num-1))+downrow));
                   for (int J = 0; J < num-(downrow+1)  ; J++)
                   {   
                       Console.Write("* ");
                   }
                   Console.WriteLine();
               }


           




        }
    }
}
