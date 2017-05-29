using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Stop_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dotUp = n;
            var lenght = ((n + 1) * 2) + (n * 2 + 1);
            Console.Write(new String('.', n + 1));
            Console.Write(new String('_', n*2+1 ));
            Console.WriteLine(new String('.', n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.Write(new String('.',dotUp));
                Console.Write("//"+new String('_',lenght-(2*dotUp+4))+"\\"+"\\");
                Console.WriteLine(new String('.', dotUp));
                dotUp--;
            }

            var stopPadding = (n - 3) * 2 + 3;
            Console.WriteLine("//"+new String('_',stopPadding)+"STOP!"+ new String('_', stopPadding)+"\\"+"\\");
            for (int j = 0; j < n; j++)
            {
                Console.Write(new String('.', dotUp));
                Console.Write("\\"+"\\" + new String('_', lenght - (2 * dotUp + 4)) + "//");
                Console.WriteLine(new String('.', dotUp));
                dotUp++;
            }
        }
    }
}
