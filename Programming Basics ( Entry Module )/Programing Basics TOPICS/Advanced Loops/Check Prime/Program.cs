using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var prime = true;
            if (num<2)
            {
                prime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;  
                }

                
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine(" Not Prime");
            }
            
         

        }
    }
}
