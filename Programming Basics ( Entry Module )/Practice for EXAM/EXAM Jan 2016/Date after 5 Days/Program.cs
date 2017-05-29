using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day =int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());


            var newDay = day + 5;

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day<=25)
                    {
                        Console.WriteLine("{0}.{1:00}", newDay, month);
                    }
                    else
                    {
                        var nextMonthday = newDay - 30;
                        Console.WriteLine("{0}.{1:00}",nextMonthday,month+1);
                    }
                    
                    ;break;

                case 2:
                    if (day <= 23)
                    {
                        Console.WriteLine("{0}.{1:00}", newDay, month);
                    }
                    else
                    {
                        var nextMonthday = newDay - 28;
                        Console.WriteLine("{0}.{1:00}", nextMonthday, month + 1);
                    }

                    ; break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day <= 26)
                    {
                        Console.WriteLine("{0}.{1:00}", newDay, month);
                    }
                    else
                    {
                        var nextMonthday = newDay - 31;
                        if (month == 12)
                        {
                            Console.WriteLine("{0}.{1:00}", nextMonthday, month - 11);
                        }
                        else
                        {
                            Console.WriteLine("{0}.{1:00}", nextMonthday, month + 1);

                        }
                        
                    }

                    ; break;


            }
        }
    }
}
