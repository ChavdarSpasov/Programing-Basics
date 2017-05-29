using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne =  Console.ReadLine();
            string wordTwo = Console.ReadLine();
            wordOne = wordOne.ToLower();
            wordTwo = wordTwo.ToLower();
            if ((wordOne) == (wordTwo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}