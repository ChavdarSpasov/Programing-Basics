using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());

            double numExcellent = 0;
            double numVerygood = 0;
            double numAverage = 0;
            double numPoor = 0;
            double allMarks = 0;

            for (int currStudent = 0; currStudent < numberStudents; currStudent++)
            {
                double currMark = double.Parse(Console.ReadLine());

                allMarks = allMarks + currMark;

                if (currMark < 3)
                {
                    numPoor++;
                }
                else if (currMark <= 3.99)
                {
                    numAverage++;
                }
                else if (currMark <= 4.99)
                {
                    numVerygood++;
                }
                else if (currMark >= 5)
                {
                    numExcellent++;
                }
            }

            double perEx = numExcellent* 100 / numberStudents;
            double perVg = numVerygood * 100 / numberStudents;
            double perAv = numAverage * 100 / numberStudents;
            double perPr = numPoor * 100 / numberStudents;

            double avMark = allMarks / numberStudents;


            Console.WriteLine("Top students: {0:f2}%",perEx);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", perVg);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", perAv);
            Console.WriteLine("Fail: {0:f2}%", perPr);
            Console.WriteLine("Average: {0:f2}", avMark);


        }
    }
}
