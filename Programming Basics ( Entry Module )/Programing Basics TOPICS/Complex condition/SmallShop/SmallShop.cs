using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var amaunt = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amaunt * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amaunt * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amaunt * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amaunt * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amaunt * 1.60);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amaunt * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amaunt * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amaunt * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amaunt * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amaunt * 1.50);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amaunt * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amaunt * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amaunt * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amaunt * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amaunt * 1.55);
                }
            }
        
        }
    }
}
