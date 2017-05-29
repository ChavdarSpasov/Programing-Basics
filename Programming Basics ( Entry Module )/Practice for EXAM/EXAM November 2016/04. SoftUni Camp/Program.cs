using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGroups = int.Parse(Console.ReadLine());
            var allGroups = 0;
            var groupCar = 0;
            var groupMicrobus = 0;
            var groupSmallbus = 0;
            var groupBigbus = 0;
            var groupTrain = 0;
            for (int i = 0; i < numberGroups; i++)
            {
                int currGroup = int.Parse(Console.ReadLine());

                allGroups += currGroup;

                if (currGroup < 6)
                {
                    groupCar += currGroup;
                }
                else if (currGroup<13)
                {
                    groupMicrobus += currGroup;
                }
                else if (currGroup<26)
                {
                    groupSmallbus += currGroup;
                }
                else if (currGroup<41)
                {
                    groupBigbus += currGroup;
                }
                else
                {
                    groupTrain += currGroup;
                }
            }

            double percentCar = groupCar / (allGroups * 100);
            double percentMicrobus = groupMicrobus / allGroups * 100;
            double percentSmallbus = groupSmallbus / allGroups * 100;
            double percentBigbus = groupBigbus / allGroups * 100;
            double percentTrain = groupTrain / allGroups * 100;

            Console.WriteLine("{0:f2}%",percentCar);
            Console.WriteLine("{0:f2}%", percentMicrobus);
            Console.WriteLine("{0:f2}%", percentSmallbus);
            Console.WriteLine("{0:f2}%", percentBigbus);
            Console.WriteLine("{0:f2}%", percentTrain);
        }
    }
}
