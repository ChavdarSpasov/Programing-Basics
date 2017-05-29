using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany_28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursforProgect =int.Parse(Console.ReadLine());
            var companyDays =int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());


            var workingdays = (companyDays - companyDays * 0.10)*8;
            var overtimeWork = (workers * 2) * companyDays;
            var totalworkingHours = Math.Floor(workingdays + overtimeWork);

            if (hoursforProgect<=totalworkingHours)
            {
                var hoursLeft = totalworkingHours - hoursforProgect;
                Console.WriteLine("Yes!{0} hours left.",hoursLeft);
            }
            else
            {
                var hoursNeeded = hoursforProgect - totalworkingHours;
                Console.WriteLine("Not enough time!{0} hours needed.",hoursNeeded);
            }

        }
    }
}
