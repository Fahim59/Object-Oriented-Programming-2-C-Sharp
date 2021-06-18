using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Triangle
    {
        private int x, y, z;

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void setName(int x)
        {
            this.x = x;
        }
        public void setId(int y)
        {
            this.y = y;
        }
        public void setDepartment(int z)
        {
            this.z = z;
        }

        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public int getZ()
        {
            return this.z;
        }

        public void showInfo()
        {
            Console.WriteLine("\n---Triangle Info---");
            Console.WriteLine("Value of X: " + x);
            Console.WriteLine("Value of Y: " + y);
            Console.WriteLine("Value of Z: " + z);
            //Console.ReadLine();
        }

        public void testTriangle()
        {
            if (x == y && x == z && y == z)
            {
                Console.WriteLine("\nThe triangle is Equilateral");
                //Console.ReadLine();
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("\nThe triangle is Isosceles");
                //Console.ReadLine();
            }
            else if (x != y && x != z && y != z)
            {
                Console.WriteLine("\nThe triangle is Scalene");
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nInvalid");
                //Console.ReadLine();
            }
        }
    }
}
