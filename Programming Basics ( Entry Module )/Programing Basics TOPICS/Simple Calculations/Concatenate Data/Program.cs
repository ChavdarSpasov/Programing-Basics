using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            var fname = Console.ReadLine();

            var lname = Console.ReadLine();

            var age = int.Parse(Console.ReadLine());

            var home = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", fname, lname, age, home);
            Console.WriteLine();
        }
    }
}
