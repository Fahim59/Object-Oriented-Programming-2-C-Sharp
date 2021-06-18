using System;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= r - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*" + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = r - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {

                    Console.Write("*" + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
