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
            Console.Write("Enter a Number: ");
            int i = Int32.Parse(Console.ReadLine());

            if(i%4 ==0)
            {
                Console.WriteLine("Divided By 4");
            }
            else if(i%6 ==0)
            {
                Console.WriteLine("Divided By 6");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            if(i%5 ==0)
            {
                Console.WriteLine("Divided By 5");
            }
        }
    }
}
