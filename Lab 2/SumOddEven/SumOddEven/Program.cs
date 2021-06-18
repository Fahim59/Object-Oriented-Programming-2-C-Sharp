using System;

namespace SumOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=100, e_sum = 0, o_sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    e_sum = e_sum + i;
                else
                    o_sum = o_sum + i;
            }

            Console.WriteLine("The sum of odd numbers between 1 to 100 is: "+o_sum);
            Console.WriteLine("The sum of even numbers between 1 to 100 is: " +e_sum);
            Console.ReadLine();
        }
    }
}
