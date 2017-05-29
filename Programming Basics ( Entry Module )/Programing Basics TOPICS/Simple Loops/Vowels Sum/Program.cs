using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var word = Console.ReadLine();

            var sum = 0;

            for (int currWord = 0; currWord < word.Length; currWord++)
            {
                if (word[currWord] == 'a')
                {
                    sum = sum + 1;
                }
                else if (word[currWord] == 'e')
                {
                    sum = sum + 2;
                }
                else if (word[currWord] == 'i')
                {
                    sum = sum + 3;
                }
                else if (word[currWord] == 'o')
                {
                    sum = sum + 4;
                }
                else if (word[currWord] == 'u')
                {
                    sum = sum + 5;
                }

            }



            Console.WriteLine(sum);

        }
    }
}
