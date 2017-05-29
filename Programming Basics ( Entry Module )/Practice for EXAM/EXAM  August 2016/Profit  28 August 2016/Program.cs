using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit__28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDaysinmonth =int.Parse(Console.ReadLine());
            var moneyperDay = double.Parse(Console.ReadLine());
            var usaCurr =double.Parse(Console.ReadLine());

            var monthSalary = workingDaysinmonth * moneyperDay;
            var yearSalary = monthSalary * 12;
            var bonus = monthSalary * 2.5;
            var totalyearSalary = yearSalary + bonus;
            var taxes = totalyearSalary * 0.25;
            var totalMoney = (totalyearSalary - taxes)*usaCurr;
            var totalMoneyperday = totalMoney / 365;


            Console.WriteLine("{0:f2}",(totalMoneyperday));

        }
    }
}
