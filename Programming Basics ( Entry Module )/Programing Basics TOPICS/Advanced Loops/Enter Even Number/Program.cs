using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter even number: ");
            
            
            while (true)
            {
                
                try
                {
                    var evenNum = int.Parse(Console.ReadLine());

                    if (evenNum % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + evenNum);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                  
                              
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    
                }
                 

            }
                
            



        }
    }
}
