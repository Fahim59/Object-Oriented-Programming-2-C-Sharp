using System;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a > 0 && a < 1 && b > 0 && b < 1);
        }
    }
}
