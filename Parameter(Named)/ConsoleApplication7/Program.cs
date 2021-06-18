using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul = Multiplication(3, 3);
            int mul1 = Multiplication(3, 3, 3);
            Console.WriteLine(mul);
            Console.WriteLine(mul1);

            double div = Division();
            Console.WriteLine(div);
        }

        static int Multiplication(int a, int b)
        {
            int mul = a * b;
            return mul;
        }

        static double Division()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            double div = c / (d + 0.0);
            return div;
        }

        static int Multiplication(int a, int b, int c)
        {
            int mul = a * b * c;
            return mul;
        }
    }
}