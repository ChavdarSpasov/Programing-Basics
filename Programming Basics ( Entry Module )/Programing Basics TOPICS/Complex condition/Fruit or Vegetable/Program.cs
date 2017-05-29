using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            /*  switch (product)
              {
                  case "banana":
                  case "aplle":
                  case "kiwi":
                  case "cherry":
                  case "lemon":
                  case "grape": Console.WriteLine("fruit");
                      break;
                  case "tomato":
                  case "cucumber":
                  case "peper":
                  case "carrot": Console.WriteLine("vegetable");
                      break;
                  default: Console.WriteLine("unknown");
                      break;
              }*/

            if (product == "banana" || product == "apple" || product == "kiwi"
                || product == "cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber"
                || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
