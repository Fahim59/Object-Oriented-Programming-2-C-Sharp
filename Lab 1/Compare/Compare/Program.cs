using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("first integer: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("second integer: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a != b && a < b && a <= b)
            {
                Console.WriteLine(a +" != "+b);
                Console.WriteLine(a + " < " + b);
                Console.WriteLine(a + " <= " + b);
            }
        }
    }
}