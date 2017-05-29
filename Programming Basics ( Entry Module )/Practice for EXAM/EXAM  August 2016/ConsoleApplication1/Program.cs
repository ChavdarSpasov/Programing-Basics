using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var examinationPeriod = int.Parse(Console.ReadLine());
            var notExaminedPatients = 0;
            var examinedPatients = 0;

            var workingDoctors = 7;

            for (int i = 1; i <= examinationPeriod; i++)
            {
                if (i % 3 == 0 && notExaminedPatients>examinedPatients)
                {
                    workingDoctors++;
                }

                var currDayPatients = int.Parse(Console.ReadLine());
                if (currDayPatients>workingDoctors)
                {
                    examinedPatients += workingDoctors ;
                    notExaminedPatients += currDayPatients - workingDoctors;
                }
                else
                {
                    examinedPatients += currDayPatients;

                }
                
            }

            Console.WriteLine("Treated patients: {0}.", examinedPatients);
            Console.WriteLine("Untreated patients: {0}.",notExaminedPatients);


        }
    }
}