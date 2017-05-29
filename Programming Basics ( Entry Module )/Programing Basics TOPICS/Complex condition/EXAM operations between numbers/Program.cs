using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var action = Console.ReadLine();
            

            if (action == "+" || action == "-" ||action == "*")
            {
                if (action == "+")
                {
                    var result = n1 + n2;
                    var even = result % 2;
                    Console.Write(n1 + " + " + n2 + " = " + result);
                    Console.WriteLine(even == 0?" - even":" - odd");
                }
                else if (action == "-")
                {
                    var result = n1 - n2;
                    var even = result % 2;
                    Console.Write(n1 + " - " + n2 + " = " + result);
                    Console.WriteLine(even == 0 ? " - even" : " - odd");
                }
                else if (action == "*")
                {
                    var result = n1 * n2;
                    var even = result % 2;
                    Console.Write(n1 + " * " + n2 + " = " + result);
                    Console.WriteLine(even == 0 ? " - even" : " - odd");
                }
            }
            else if (action == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    var result = n1 / n2;
                    Console.WriteLine(n1 + " / " + n2 + " = " + Math.Round(result, 2));
                }
                              
            }
            else if (action == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    var result = n1 % n2;
                    Console.WriteLine(n1 + " % " + n2 + " = " + result);
                }
                              
            }
            
        }
    }
}
