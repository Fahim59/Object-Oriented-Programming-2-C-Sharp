using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the value till you want to find Even Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers are: ");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                    Console.ReadLine();
        }
    }
}
