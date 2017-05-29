using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numBricks = double.Parse(Console.ReadLine());
            var numWorkers = int.Parse(Console.ReadLine());
            var cartQuantity = int.Parse(Console.ReadLine());

            var quantityofbricksperLode = numWorkers * cartQuantity;
            
            var numLodes = Math.Ceiling(numBricks / quantityofbricksperLode);
            
            Console.WriteLine("{0}",numLodes);
 

        }
    }
}
