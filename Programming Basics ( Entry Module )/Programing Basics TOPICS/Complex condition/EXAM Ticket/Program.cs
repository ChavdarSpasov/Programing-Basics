using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            var money = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());
            var result = 0.0;
            var tickets = 0.0;
            if (category == "vip")
            {
                tickets = people * 499.99;
                if (people <= 4 && people >= 1)
                {
                    result = money * 0.75;
                }
                else if (people >= 5 && people <= 9)
                {
                    result = money * 0.60;
                }
                else if (people >= 10 && people <= 24)
                {
                    result = money * 0.50;
                }
                else if (people >= 25 && people <= 49)
                {
                    result = money * 0.40;
                }
                else if (people >= 50)
                {
                    result = money * 0.25;
                }
                            
            }
            else if (category== "normal")
            {
                tickets = people * 249.99;
                if (people <= 4 && people >= 1)
                {
                    result = money * 0.75;
                }
                else if (people >= 5 && people <= 9)
                {
                    result = money * 0.60;
                }
                else if (people >= 10 && people <= 24)
                {
                    result = money * 0.50;
                }
                else if (people >= 25 && people <= 49)
                {
                    result = money * 0.40;
                }
                else if (people >= 50)
                {
                    result = money * 0.25;
                }

            }

            var leftMoney = money - result;
            if (tickets < leftMoney)
            {
                var savemoney = (leftMoney - tickets);
                Console.WriteLine("Yes! You have {0:f2} leva left",savemoney);
            }
            else
            {
                var savemoney = (tickets - leftMoney);
                Console.WriteLine("Not enough money! You need {0:f2} leva ",savemoney);
            }

        }
    }
}
