using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Course
    {
        private String courseName, courseCode;
        private int courseCredit;

        public Course(String courseName, String courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void setCourseName(String courseName)
        {
            this.courseName = courseName;
        }
        public void setCourseCode(String courseCode)
        {
            this.courseCode = courseCode;
        }
        public void setCourseCredit(int courseCredit)
        {
            this.courseCredit = courseCredit;
        }

        public String getCourseName()
        {
            return this.courseName;
        }
        public String getCourseCode()
        {
            return this.courseCode;
        }
        public int getCourseCredit()
        {
            return this.courseCredit;
        }

        public void showCourseInfo()
        {
            Console.WriteLine("\n---Course Info---");
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Id: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
            Console.ReadLine();
        }
    }
}
