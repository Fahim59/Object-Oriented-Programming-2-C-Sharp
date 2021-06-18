using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,result;
            string opt;

            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            opt = Console.ReadLine();

            if(opt == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else if(opt == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if(opt == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if(opt == "/")
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
