using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int currNum = 1; currNum <= n; currNum+=3)
            {
                Console.WriteLine(currNum);
            }
        }
    }
}
