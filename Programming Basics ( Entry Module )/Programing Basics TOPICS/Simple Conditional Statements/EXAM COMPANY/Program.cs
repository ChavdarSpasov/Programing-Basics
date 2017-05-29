using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_COMPANY
{
    class Program
    {
        static void Main(string[] args)
        {
           int progectHours = int.Parse(Console.ReadLine());
           int progectDays = int.Parse(Console.ReadLine());
           int overtimeWorkers = int.Parse(Console.ReadLine());
            double overtimeHours = overtimeWorkers * (progectDays * 2);
            double workHours = (((progectDays - (progectDays * 10) / 100)) * 8);
            double totalHours = Math.Floor(workHours + overtimeHours);
            if (totalHours < progectHours)
            {
                var leftHours =(progectHours - totalHours);
                Console.WriteLine("Yes!{0} hours left.",(leftHours));
            }
            else
            {
                var leftHours = totalHours - progectHours;
                Console.WriteLine("Not enough time!{0} hours needed.",(leftHours));
            } 
        }
    }
}