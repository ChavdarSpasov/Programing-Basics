using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;

            var stars = 0;
            var dashes = width - 2 -stars;

            for (int i = 0; i < n; i++)
            {
                stars++;
                dashes -= 2;

                Console.WriteLine("{0}\\{1}/{2}",
                    new string('*', stars),
                    new string('-',dashes),
                    new string('*',stars));                
            }

            var sideStars = stars / 2;
            var midStars = stars;

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{2}|",
                    new string('*', sideStars),
                    new string('*', midStars),
                    new string('*', sideStars));

                sideStars++;
                midStars -= 2;
            }

            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}",
                    new string('-', dashes),
                    new string('*', width - 2 -dashes *2),
                    new string('-', dashes));

                dashes++;
                
            }

        }
    }
}
