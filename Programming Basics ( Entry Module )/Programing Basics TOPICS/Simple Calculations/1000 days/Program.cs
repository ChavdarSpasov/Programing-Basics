using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;4
using System.Threading.Tasks;
using System.Globalization; 

namespace _1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter Birdth date :");
            var birthData = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",provider);
            Console.WriteLine(birthData.AddDays(1000).ToString("dd-MM-yyyy"));
        }
    }
}
