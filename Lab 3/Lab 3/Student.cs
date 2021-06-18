using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        private String name, id, department;
        private float cgpa;

        public Student(String name, String id, String department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public void setDepartment(String department)
        {
            this.department = department;
        }
        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }

        public String getName()
        {
            return this.name;
        }
        public String getId()
        {
            return this.id;
        }
        public String getDepartment()
        {
            return this.department;
        }
        public float getCgpa()
        {
            return this.cgpa;
        }

        public void showInfo()
        {
            Console.WriteLine("---Student Info---");
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Id: " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student CGPA: " + cgpa);
            //Console.ReadLine();
        }
    }
}
