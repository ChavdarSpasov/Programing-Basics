using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount to convert:");
            var amount = double.Parse(Console.ReadLine());
            Console.WriteLine("from Currency:");
            var fCur = Console.ReadLine();
            Console.WriteLine("to Currency:");
            var sCur = Console.ReadLine();
            double BGN = 1;
            double USD = BGN * 1.79549;
            double EUR = BGN * 1.95585;
            double GBR = BGN * 2.53405; 
            if (fCur == "BGN" )
            {
                if (sCur == "USD")
                {
                    Console.WriteLine(Math.Round((amount * BGN/USD),2)  + " USD");
                }
                if (sCur == "EUR")
                {
                    Console.WriteLine(Math.Round((amount * BGN)/EUR,2) + " EUR");
                }
                if (sCur == "GBR")
                {
                    Console.WriteLine(Math.Round((amount * BGN)/GBR,2) + " GBR");
                }
            }
            else if (fCur == "USD")
            {
                if (sCur == "BGN")
                {
                    Console.WriteLine(Math.Round((amount * USD)/BGN,2) + " BGN");
                }
                if (sCur == "EUR")
                {
                    Console.WriteLine(Math.Round(amount * USD/EUR,2) + " EUR");
                }
                if (sCur == "GBR")
                {
                    Console.WriteLine(Math.Round(amount * USD/GBR,2) + " GBR");
                }
            }
            else if (fCur == "EUR")
            {
                if (sCur == "USD")
                {
                    Console.WriteLine(Math.Round(amount * EUR / USD,2)  + " USD");
                }
                if (sCur == "BGN")
                {
                    Console.WriteLine(Math.Round(amount * EUR / BGN,2) + " BGN");
                }
                if (sCur == "GBR")
                {
                    Console.WriteLine(Math.Round(amount * EUR / GBR,2) + " GBR");
                }
            }
            else if (fCur == "GBR")
            {
                if (sCur == "USD")
                {
                    Console.WriteLine(Math.Round(amount * GBR / USD,2) + " USD");
                }   
                if (sCur == "EUR")
                {
                    Console.WriteLine(Math.Round(amount * GBR/ EUR,2) + " EUR");
                }
                if (sCur == "BGN")
                {
                    Console.WriteLine(Math.Round((amount * GBR / BGN),2) + " GBR");
                }
            }



        }
    }
}
