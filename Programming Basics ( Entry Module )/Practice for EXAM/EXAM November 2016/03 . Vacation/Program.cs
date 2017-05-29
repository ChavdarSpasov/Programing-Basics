using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOldpeople = int.Parse(Console.ReadLine());
            int numberYongpeople = int.Parse(Console.ReadLine());
            int numberNights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double priceOld = 0;
            double priceYong = 0;

            switch (transport)
            {
                case "train": priceOld = 24.99 * numberOldpeople; priceYong = 14.99 * numberYongpeople; break;
                case "bus": priceOld = 32.50 * numberOldpeople; priceYong = 28.50 * numberYongpeople; break;
                case "ship": priceOld = 42.99 * numberOldpeople; priceYong = 39.99 * numberYongpeople; break;
                case "airplane": priceOld = 70.00 * numberOldpeople; priceYong = 50.00 * numberYongpeople; break;
            }


            var totalPrice = priceYong + priceOld;

            if (numberOldpeople + numberOldpeople >= 50 && transport == "train")
            {
                totalPrice = totalPrice - (0.50 * totalPrice);
            }

            var pricePernight = numberNights * 82.99;
            var taxes = (totalPrice + pricePernight) * 0.10;
            var endPrice = totalPrice + pricePernight + taxes;

            Console.WriteLine("{0:0.00}",endPrice);

        }
    }
}
