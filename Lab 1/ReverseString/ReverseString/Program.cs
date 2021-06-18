using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";
            int Length = 0;

            Console.Write("Enter a Word: "); 
            str = Console.ReadLine();

            Length = str.Length - 1;  //Calculate length of string str
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
 
            Console.Write("Reverse word is: " +reverse);
            Console.ReadLine();
        }
    }
}
