using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Mustafizur Rahman", "18-36179-1", "CSSE", 3.79f);
            s.showInfo();

            Triangle t = new Triangle(2,2,2);
            t.showInfo();
            t.testTriangle();

            Account a1 = new Account("Fahim Rahman", "A-001", 5000);
            Account a2 = new Account("Faysal Hasan", "A-002", 6000);
            a1.showInfo();

            a1.deposit(1000);
            a1.deposit(-200);
            a1.withdraw(2000);
            a1.withdraw(-100);
            a2.transfer(500, a1);

            Course c = new Course("C#", "C-001", 3);
            c.showCourseInfo();
            
        }
    }
}
