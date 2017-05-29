using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine().ToLower();
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal result = 0.1M;





            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    result = sales * 0.05M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    result = sales * 0.07M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    result = sales * 0.08M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 10000)
                {
                    result = sales * 0.12M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    result = sales * 0.045M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    result = sales * 0.075M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    result = sales * 0.1M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 10000)
                {
                    result = sales * 0.13M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    result = sales * 0.055M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    result = sales * 0.08M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    result = sales * 0.12M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else if (sales > 10000)
                {
                    result = sales * 0.145M;
                    Console.WriteLine("{0:f2} leva", result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(town != "sofia" || town != "varna" || town != "plovdiv")
            {
                Console.WriteLine("error");
            }
            

            
    
        }
    }
}
