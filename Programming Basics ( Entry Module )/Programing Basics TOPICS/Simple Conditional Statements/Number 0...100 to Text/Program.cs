using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());                 
            int thenths = (num / 10);
            int units = (num % 10);

            // 1 2 3 ...
            if (num < 0 || num >= 101)
            {
                Console.WriteLine("invalid number");
            }

            if (units == 0 && thenths == 0)
            {
                Console.WriteLine("zero");
            }
            else if (units == 0 && thenths == 10)
            {
                Console.WriteLine("one hundred");
            }

            if (units == 1 && thenths == 0)
            {
                Console.WriteLine("one");
            }
            else if (units == 2 && thenths == 0)
            {
                Console.WriteLine("two");
            }
            else if (units == 3 && thenths == 0)
            {
                Console.WriteLine("three");
            }
            else if (units == 4 && thenths == 0)
            {
                Console.WriteLine("four");
            }
            else if (units == 5 && thenths == 0)
            {
                Console.WriteLine("five");
            }
            else if (units == 6 && thenths == 0)
            {
                Console.WriteLine("six");
            }
            else if (units == 7 && thenths == 0)
            {
                Console.WriteLine("seven");
            }
            else if (units == 8 && thenths == 0)
            {
                Console.WriteLine("eight");
            }
            else if (units == 9 && thenths == 0)
            {
                Console.WriteLine("nine");
            }
            // 11 12 13 ...
            if (thenths == 1 && units == 1)
            {
                Console.WriteLine("eleven");
            }
            if (thenths == 1 && units == 2)
            {
                Console.WriteLine("twelve");
            }
            if (thenths == 1 && units == 3)
            {
                Console.WriteLine("thirteen");
            }
            if (thenths == 1 && units == 4)
            {
                Console.WriteLine("fourteen");
            }
            if (thenths == 1 && units == 5)
            {
                Console.WriteLine("fifteen");
            }
            if (thenths == 1 && units == 6)
            {
                Console.WriteLine("sixteen");
            }
            if (thenths == 1 && units == 7)
            {
                Console.WriteLine("seventeen");
            }
            if (thenths == 1 && units == 8)
            {
                Console.WriteLine("eighteen");
            }
            if (thenths == 1 && units == 9)
            {
                Console.WriteLine("nineteen");
            }
            //20 30 40 ...
            if (thenths == 1 && units == 0)
            {
                Console.WriteLine("ten");
            }
            if (thenths == 2 && units == 0)
            {
                Console.WriteLine("twenty");
            }
            else if (thenths == 3 && units == 0)
            {
                Console.WriteLine("thirty");
            }
            else if (thenths == 4 && units == 0)
            {
                Console.WriteLine("fourty");
            }
            else if (thenths == 5 && units == 0)
            {
                Console.WriteLine("fifty");
            }
            else if (thenths == 6 && units == 0)
            {
                Console.WriteLine("sixty");
            }
            else if (thenths == 7 && units == 0)
            {
                Console.WriteLine("seventy");
            }
            else if (thenths == 8 && units == 0)
            {
                Console.WriteLine("eighty");
            }
            else if (thenths == 9 && units == 0)
            {
                Console.WriteLine("ninety");
            }
            // 24 76 56 ...
            if (thenths == 2 && units > 0 && units <= 9)
            {
                Console.Write("twenty");
            }
            else if (thenths == 3 && units > 0 && units <= 9)
            {
                Console.Write("thirty");
            }
            else if (thenths == 4 && units > 0 && units <= 9)
            {
                Console.Write("fourty");
            }
            else if (thenths == 5 && units > 0 && units <= 9)
            {
                Console.Write("fifty");
            }
            else if (thenths == 6 && units > 0 && units <= 9)
            {
                Console.Write("sixty");
            }
            else if (thenths == 7 && units > 0 && units <= 9)
            {
                Console.Write("seventy");
            }
            else if (thenths == 8 && units > 0 && units <= 9)
            {
                Console.Write("eighty");
            }
            else if (thenths == 9 && units > 0 && units <= 9)
            {
                Console.Write("ninety");
            }
            if (units == 1 && thenths > 1 && thenths <= 9 )
            {
                Console.WriteLine(" one");
            }
            else if (units == 2 && thenths > 1 && thenths <= 9 )
            {
                Console.WriteLine(" two");
            }
            else if (units == 3 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" three");
            }
            else if (units == 4 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" four");
            }
            else if (units == 5 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" five");
            }
            else if (units == 6 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" six");
            }
            else if (units == 7 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" seven");
            }
            else if (units == 8 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" eight");
            }
            else if (units == 9 && thenths > 1 && thenths <= 9)
            {
                Console.WriteLine(" nine");
            }
   
            
        }
    }
}