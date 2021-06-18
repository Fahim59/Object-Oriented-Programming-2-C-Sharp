using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.Write("Enter a positive number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " +n+ " is: " +fact);
            Console.ReadLine();
        }
    }
}
