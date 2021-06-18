using System;

namespace DivideTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum;

            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());

            sum = a / b;

            Console.WriteLine("Division of a and b is: " + sum);
        }
    }
}
