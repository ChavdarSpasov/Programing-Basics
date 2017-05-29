using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var size = 3 * n;
            var sideDots = n + (n/2-1);
            var emptySpace = 0;
            var stars = 0;
            var htags = 0;
           
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("{0}/{1}\\{2}",new string('.',sideDots),
                                                     new string(' ',emptySpace),
                                                     new string('.', sideDots));

                sideDots --;
                emptySpace += 2;
                stars += 2;
                htags += 2;


                }


            sideDots++;
            emptySpace -= 2;
            stars -= 2;
            htags -= 2;




            Console.WriteLine("{0}*{1}*{2}", new string('.', sideDots),
                                                 new string('*', stars),
                                                 new string('.', sideDots));


            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{2}", new string('.', sideDots), 
                                                 new string('\\', htags), 
                                                 new string('.', sideDots));

            }


            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine("{0}/{1}\\{2}", new string('.', sideDots),
                                                 new string('*', stars),
                                                 new string('.', sideDots));


                sideDots--;
                stars += 2;




            }


        }
    }
}
