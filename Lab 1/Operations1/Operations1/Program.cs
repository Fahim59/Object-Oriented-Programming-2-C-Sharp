using System;

namespace Operations1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=25.5, b=3.5, c=40.5, d=4.5, expression;

            expression = ((a * b - b * b) / (c - d));

            Console.WriteLine("\nResult of the expression is: " + expression);
            Console.ReadLine();
        }
    }
}