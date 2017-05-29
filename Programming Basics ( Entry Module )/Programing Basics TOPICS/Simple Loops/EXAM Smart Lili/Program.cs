using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceofWM = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var savedMoney = 0;
            var toy = 0;
            for (int currNum = 1; currNum <= age ; currNum++)
            {
                
                if (currNum % 2 != 0)
                {
                    toy++; 
                }

                else if (currNum == 2)
                {
                    savedMoney = savedMoney + 9;
                }              
                else if (currNum > 2 && currNum % 2 == 0)
                {
                    savedMoney = (savedMoney + (currNum / 2) * 10) - 1;
                }
                
            }

            var toyMOney = toy * toyPrice;
            var allSavedmoney = savedMoney + toyMOney;

            if (allSavedmoney > priceofWM)

            {
                Console.WriteLine("Yes! {0:F2}",allSavedmoney - priceofWM);
            }
            else
            {
                Console.WriteLine("No! {0:F2}",priceofWM - allSavedmoney);
            }





        }
    }
}
