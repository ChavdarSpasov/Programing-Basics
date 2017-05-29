using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM__Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {

            var month = Console.ReadLine();
            var night = double.Parse(Console.ReadLine());

            var sPrice = 1.0;
            var aPrice = 1.0;





            if (month == "May" || month == "October")
            {
                sPrice = night * 50;
                aPrice = night * 65;

            }
            else if (month == "June" || month == "September")
            {
                sPrice = night * 75.20;
                aPrice = night * 68.70;

            }
            else if (month == "July" || month == "August")
            {
                sPrice = night * 76;
                aPrice = night * 77;

            }


            if ((night > 7 && night <= 14) && (month == "May" || month == "October"))
            {
                var discount = sPrice * 0.05;
                sPrice = sPrice - discount;
            }
            if ((night > 14) && (month == "May" || month == "October"))
            {
                var discount = sPrice * 0.30;
                sPrice = sPrice - discount;
            }
            if (night > 14 && month == "June" || month == "September")
            {
                var discount = sPrice * 0.20;
                sPrice = sPrice - discount;
            }
            if (night > 14 && (month == "June" || month == "September"
                || month == "May" || month == "October"
                || month == "June" || month == "August"))
            {
                var discount = aPrice * 0.10;
                aPrice = aPrice - discount;
            }




            Console.WriteLine("Apartment: {0:f2} lv.", aPrice);
            Console.WriteLine("Studio: {0:f2} lv.", sPrice);

        }
    }
}
