using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
     {
          int x = 4, y = 5;

          Swap(ref x, ref y);

          Console.WriteLine(x+ "\t" +y);
     }​​​​​​

        static void Swap( ref int a, ref int b)
        {​​​​​​
           int c;

           c = a;
           a = b;
           b = c;
        }
    }
}