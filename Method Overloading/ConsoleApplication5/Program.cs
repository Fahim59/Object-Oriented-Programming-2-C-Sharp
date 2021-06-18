using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Calculation(int a, int b)
        {
            int addition = a+ b;
            Console.WriteLine("The Summation of {0} and {1} is {2}  ",a,b,addition); 
        }
        static void Calculation(int c, int d, int e)
        {
            int multiplication = c * d * e;
            Console.WriteLine("The Multiplication of {0}, {1} and {2}  is {3}  ", c, d, e, multiplication);  
        }
        static void Main(string[] args)
        {
            Calculation(5, 7); 
            Calculation(2, 3, 3); 
        }
    }
}
