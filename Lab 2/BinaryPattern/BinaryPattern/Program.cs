using System;

namespace BinaryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                int s;

                if (i % 2 == 0)
                {
                    s = 0;

                    for (int j = 1; j <= r; j++)
                    {
                        Console.Write(s);
                        s = (s == 0) ? 1 : 0;
                    }
                }
                else
                {
                    s = 1;
                    for (int j = 1; j <= r; j++)
                    {
                        Console.Write(s);
                        s = (s == 0) ? 1 : 0;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
