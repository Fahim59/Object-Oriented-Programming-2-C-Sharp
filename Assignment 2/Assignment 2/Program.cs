using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the ID: ");
            string s = Console.ReadLine();

            string year = s.Substring(0, 2);
            string month = s.Substring(2, 2);

            string [] parts = s.Split('-');

            if(parts.Length != 3)
            {
                Console.WriteLine("Invalid Id");
                return;
            }

            string ym = parts[0];
            string serial = parts[1];
            string type = parts[2];

            if (ym.Length != 4 || serial.Length != 4 || type.Length != 1)
            {
                Console.WriteLine("Invalid Id");
                return;
            }

            Console.WriteLine("Year :" + year);

            int month1 = Convert.ToInt32(month);

            if(month1 > 12 || month1 <= 0)
            {
                Console.WriteLine("Invalid Month");
                return;
            }
            else
            {
                Console.WriteLine("Month :" + month1);
            }

            Console.WriteLine("Serial :" + serial);

            if(type == "1")
            {
                Console.WriteLine("Type : Admin");
            }
            else if(type == "2")
            {
                Console.WriteLine("Type : Faculty");
            }
            else if(type == "3")
            {
                Console.WriteLine("Type : Employee");
            }
            else if(type == "4")
            {
                Console.WriteLine("Type : Staff");
            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
    }
}