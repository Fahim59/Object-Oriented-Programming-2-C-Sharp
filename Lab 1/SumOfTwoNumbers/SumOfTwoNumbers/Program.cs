using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            /*a = 10;
            b = 5;
            sum = a + b;*/

            Console.Write("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("Sum of a and b is: " + sum);

            Console.ReadLine();
        }
    }
}
