using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_exam_on_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = double.Parse(Console.ReadLine());
            var examMinute = double.Parse(Console.ReadLine());
            var arriveHour = double.Parse(Console.ReadLine());
            var arriveMinute = double.Parse(Console.ReadLine());

            var exam = examHour * 60 + examMinute;
            var arrive = arriveHour * 60 + arriveMinute;
            var result = exam - arrive;
            var result1 = arrive - exam;

            
            if (arrive < exam)
            {                
                if ((result > 0 && result <=30))
                {
                    Console.WriteLine("On time\n{0} minutes before the start",result);
                }
                else if (result >30 && result < 60)
                {
                    Console.WriteLine("Early\n{0} minutes before the start", result);
                }
                else
                {
                    var hour = Math.Truncate(result / 60);
                    var minute = result % 60;

                    Console.WriteLine("Early\n{0}:{1:00} hours before the start", hour, minute);
                }
                
            }
            else if (arrive > exam)
            {
                if (result1 <60)
                {
                    Console.WriteLine("Late\n{0:00} minutes after the start,",result1);

                }
                else
                {
                    var hour = Math.Truncate(result1 / 60);
                    var minute = result1 % 60;

                    Console.WriteLine("Late\n{0}:{1:00} hours after the start",hour,minute);
                }
            }
            else if (arrive == exam)
            {
                Console.WriteLine("On time");
            } 

        }
    }
}
