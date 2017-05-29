using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Drow_Ford
{
    class Program
    {
        static void Main(string[] args)
        {
              var n =int.Parse(Console.ReadLine());
              Console.Write("/"+new String ('^',n/2)+"\\");
              if (n>4)
              {
                  Console.Write(new String('_', (2*n)-2*(n/2)-4));
              }
              Console.WriteLine("/" + new String('^', n / 2) + "\\");

              if (n > 4)
              {
                  for (int i = 0; i < n - 3; i++)
                  {
                      Console.Write("|");
                      Console.Write(new String(' ', 2*n-2));
                      Console.WriteLine("|");
                  }
                  Console.Write("|");
                  Console.Write(new String(' ', (n / 2)+1));
                  Console.Write(new String('_', 2*n-2*(n/2)-4));
                  Console.Write(new String(' ', (n / 2) + 1));
                  Console.WriteLine("|");
                  Console.Write("\\" + new String('_', n / 2) + "/");
                  Console.Write(new String(' ', (2 * n) - 2*(n/2) - 4));
                  Console.WriteLine("\\" + new String('_', n / 2) + "/");
              }
              else
              {
                  for (int i = 0; i < n-2; i++)
                  {
                      Console.Write("|");
                      Console.Write(new String(' ',(n / 2)*2+2));
                      Console.WriteLine("|");
                  }

                  Console.Write("\\" + new String('_', n / 2) + "/");            
                  Console.WriteLine("\\" + new String('_', n / 2) + "/");
              }
              


           
        }
    }
}
