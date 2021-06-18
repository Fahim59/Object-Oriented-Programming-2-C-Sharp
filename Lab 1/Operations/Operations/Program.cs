using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, sum1, sum2, sum3, sum4;

            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of e: ");
            e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of f: ");
            f = Convert.ToDouble(Console.ReadLine());

            sum1 = a + b * c;
            sum2 = (a + b) % c;
            sum3 = a + b * c / d;
            sum4 = a + b / c * d - e % f;


            Console.WriteLine("\nResult of part a is: " + sum1);
            Console.WriteLine("\nResult of part b is: " + sum2);
            Console.WriteLine("\nResult of part c is: " + sum3);
            Console.WriteLine("\nResult of part d is: " + sum4);

            Console.ReadLine();
        }
    }
}