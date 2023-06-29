using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeAdminApp
{
    class Instructor
    {
        //instructor is initialized with properties: ID, Name, CollegeName, CourseTeaching, and StudentName

        //private properties of college object
        //private int[] _ID = new int[] { 1, 2, 3, 4, 5 };
        //private string[] _Name = new string[] { "John Doe", "Henry Thomas", "John King", "Abraham Lincoln", "John F Kennedy" };
        //private string[] _CollegeName = new string[] { "Harvard University", "Princeton University", "Massachusetts Institute of Technology", "Stanford University", "Yale University" };
        //private string[] _CourseTeaching = new string[] { "English", "Spanish", "Computer Science", "Maths", "Physics" };
        //private string[] _StudentName = new string[] { "Julio Middleton", "Piper Wu", "Gianni Velez", "Kareem Molina", "John Middleton" };

        private int[] _ID = new int[] {};
        private string[] _Name = new string[] {};
        private string[] _CollegeName = new string[] {};
        private string[] _CourseTeaching = new string[] {};
        private string[] _StudentName = new string[] {};

        //public properties of college object
        public int[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] CollegeName { get { return _CollegeName; } set { _CollegeName = value; } }
        public string[] CourseTeaching { get { return _CourseTeaching; } set { _CourseTeaching = value; } }
        public string[] StudentName { get { return _StudentName; } set { _StudentName = value; } }

        public void getInstructorNames()
        {
            Console.WriteLine("\n------------------------ Instructors List ---------------------------");
            for (int i = 0; i <= ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("College Name: " + this.CollegeName[i]);
                Console.WriteLine("CourseTeaching: " + this.CourseTeaching[i]);
                Console.WriteLine("Student Name: " + this.StudentName[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
        }

    }
}
