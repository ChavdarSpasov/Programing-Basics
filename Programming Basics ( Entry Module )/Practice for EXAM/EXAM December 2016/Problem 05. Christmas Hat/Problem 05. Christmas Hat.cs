using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int high = 2 * num + 5;
            int wide = 4 * num + 1;

            int dot = 2 * num - 1;
            int dash = 0;
            Console.WriteLine("{0}/|\\{0}",new String('.',dot));
            Console.WriteLine("{0}\\|/{0}",new String('.',dot));

            for (int i = 0; i < num * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new String('.', dot),
                    new String('-', dash),
                    new String('-', dash),
                    new String('.', dot));


                dot--;
                dash++;

            }



            Console.WriteLine(new String('*',wide));
            for (int i = 0; i < wide / 2; i++)
            {                                
                Console.Write("*");              
                Console.Write(".");
            }
            Console.WriteLine("*");
            Console.WriteLine(new String('*',wide));
        }
    }
}
