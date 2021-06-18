using System;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            double marks;

            Console.Write("Enter Your Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

            if (marks < 50)
            {
                Console.Write("Your Grade is F");
            }
            else if (marks >= 50 && marks <= 74)
            {
                Console.Write("Your Grade is C+");
            }
            else if (marks >= 75 && marks <= 79)
            {
                Console.Write("Your Grade is B");
            }
            else if (marks >= 80 && marks <= 84)
            {
                Console.Write("Your Grade is B+");
            }
            else if (marks >= 85 && marks <= 89)
            {
                Console.Write("Your Grade is A");
            }
            else if (marks >= 90)
            {
                Console.Write("Your Grade is A+");
            }
            else
            {
                Console.Write("Invalid Marks");
            }
            Console.ReadLine();
        }
    }
}
