using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int amountNum = int.Parse(Console.ReadLine());
         
            var sum = 0.0;


            for (int currNum = 0; currNum < amountNum; currNum++)
            {
              
                
                var countNum = double.Parse(Console.ReadLine());
                sum = sum + countNum;
            }
          
            Console.WriteLine("Youre sum is:" + sum);
        }
    }
}
