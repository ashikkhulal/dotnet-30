using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeAdminApp
{
    class Student
    {
        //student is initialized with properties: ID, Name, College, CourseEnrolled, and Instructor

        //private properties of college object
        private int[] _ID = new int[] { 1, 2, 3, 4, 5 };
        private string[] _Name = new string[] { "Julio Middleton", "Piper Wu", "Gianni Velez", "Kareem Molina", "John Middleton" };
        private string[] _CollegeName = new string[] { "Harvard University", "Princeton University", "Massachusetts Institute of Technology", "Stanford University", "Yale University" };
        private string[] _CourseEnrolled = new string[] { "English", "Spanish", "Computer Science", "Maths", "Physics" };
        private string[] _Instructor = new string[] { "John Doe", "Henry Thomas", "John King", "Abraham Lincoln", "John F Kennedy" };

        //public properties of college object
        public int[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] CollegeName { get { return _CollegeName; } set { _CollegeName = value; } }
        public string[] CourseEnrolled { get { return _CourseEnrolled; } set { _CourseEnrolled = value; } }
        public string[] Instructor { get { return _Instructor; } set { _Instructor = value; } }

        public void getStudentNames()
        {
            Console.WriteLine("\n-------------------------- Student List -----------------------------");
            for (int i = 0; i < ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("College Name: " + this.CollegeName[i]);
                Console.WriteLine("Course Enrolled: " + this.CourseEnrolled[i]);
                Console.WriteLine("Instructor: " + this.Instructor[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
        }
    }
}
