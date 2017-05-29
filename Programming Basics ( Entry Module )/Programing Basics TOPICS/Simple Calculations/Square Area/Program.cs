using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter nomber N:");
            var n = int.Parse(Console.ReadLine());
            int area = n * n;
            Console.WriteLine("The square area is: {0}", area );
            /*
            Console.WriteLine("The square are is");
            Console.Write(area);
             */ 
        }
    }
}