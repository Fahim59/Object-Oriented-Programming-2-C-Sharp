using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, area, perimeter;

            Console.Write("Enter the value of Width: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            area= width * height;
            perimeter= 2 * (width + height);

            Console.WriteLine("\nArea is " + width + " * " + height + " = " +area);
            Console.WriteLine("\nPeremeter is 2 * " + "("+width+ " + " +height+")"+ " = " + perimeter);
            Console.ReadLine();
        }
    }
}