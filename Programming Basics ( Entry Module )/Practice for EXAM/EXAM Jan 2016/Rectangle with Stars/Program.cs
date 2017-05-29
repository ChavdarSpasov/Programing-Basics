using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine()); 

            Console.WriteLine(new string('%',(n*2)));


            if (n % 2 != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                   
                    if (i==n/2+1)
                    {
                       
                        Console.Write("%");
                        Console.Write(new string(' ',( n * 2 - 4) / 2));
                        Console.Write("**");
                        Console.Write(new string(' ', (n * 2 - 4) / 2));
                        Console.WriteLine("%");
                    }
                    else
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (n * 2) - 2));
                        Console.WriteLine("%");
                    }
                    
                }
            }
            else
            {
                for (int j = 1; j <= n-1; j++)
                {

                    if (j == (n-1) / 2 + 1)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (n * 2 - 4) / 2));
                        Console.Write("**");
                        Console.Write(new string(' ', (n * 2 - 4) / 2));
                        Console.WriteLine("%");
                    }
                    else
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (n * 2) - 2));
                        Console.WriteLine("%");
                    }

                }
            }
            

            Console.WriteLine(new string('%', (n * 2)));


        }
    }
}
