using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace collegeAdminApp
{
    class Student
    {
        //student is initialized with properties: ID, Name, College, CourseEnrolled, and Instructor

        //private properties of student
        private string[] _ID;
        private string[] _Name;
        private string[] _CollegeName;
        private string[] _CourseEnrolled;
        private string[] _Instructor;

        //public properties of student
        public string[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] CollegeName { get { return _CollegeName; } set { _CollegeName = value; } }
        public string[] CourseEnrolled { get { return _CourseEnrolled; } set { _CourseEnrolled = value; } }
        public string[] Instructor { get { return _Instructor; } set { _Instructor = value; } }

        //method to get students name
        public void getStudentNames()
        {
            Console.WriteLine("\n-------------------------- Student List -----------------------------");
            for (int i = 0; i < this.ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("College: " + this.CollegeName[i]);
                Console.WriteLine("Course Enrolled: " + this.CourseEnrolled[i]);
                Console.WriteLine("Instructor: " + this.Instructor[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
        }

        //method to add students name
        public void addStudentName(int countAdd)
        {
            this.ID = new string[countAdd];
            this.Name = new string[countAdd];
            this.CollegeName = new string[countAdd];
            this.CourseEnrolled = new string[countAdd];
            this.Instructor = new string[countAdd];

            for (int i = 0; i < countAdd; i++)
            {
                Console.WriteLine("\nEnter the student details below for ID" + i + ":");
                Console.Write("ID: ");
                this.ID[i] = Console.ReadLine();
                Console.Write("Name: ");
                this.Name[i] = Console.ReadLine();
                Console.Write("College: ");
                this.CollegeName[i] = Console.ReadLine();
                Console.Write("Course Enrolled: ");
                this.CourseEnrolled[i] = Console.ReadLine();
                Console.Write("Instructor: ");
                this.Instructor[i] = Console.ReadLine();
            }
        }

        //method to remove students name
        public void removeStudentName(string remove)
        {
            //capture the index of the ID user wants to remove in index variable
            int index = Array.IndexOf(ID, remove);

            //output removal student details
            Console.WriteLine("\nYou want to remove below student details: \n");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("ID: " + this.ID[index]);
            Console.WriteLine("Name: " + this.Name[index]);
            Console.WriteLine("College: " + this.CollegeName[index]);
            Console.WriteLine("Course Enrolled: " + this.CourseEnrolled[index]);
            Console.WriteLine("Instructor: " + this.Instructor[index]);
            Console.WriteLine("--------------------------------------------------------------------");

            //confirm removal
            Console.Write("Are you sure you want to delete it? Enter Y/y to confirm: ");
            string Confirm = Console.ReadLine();

            //condition if user confirms to remove the student
            if (Confirm != "Y" || Confirm != "y")
            {
                //removing ID array using where clause
                this.ID = this.ID.Where(e => e != this.ID[index]).ToArray();

                //removing Name array using where clause
                this.Name = this.Name.Where(e => e != this.Name[index]).ToArray();

                //removing CollegeName array using where clause
                this.CollegeName = this.CollegeName.Where(e => e != this.CollegeName[index]).ToArray();

                //removing CourseEnrolled array using where clause
                this.CourseEnrolled = this.CourseEnrolled.Where(e => e != this.CourseEnrolled[index]).ToArray();

                //removing Instructor array using where clause
                this.Instructor = this.Instructor.Where(e => e != this.Instructor[index]).ToArray();
            }

            if (this.ID.Length > 0)
            {
                //output new student list
                Console.WriteLine("\nAfter deletion: ");
                Console.WriteLine("\n-------------------------- New Student List ---------------------------");
                for (int i = 0; i < this.ID.Length; i++)
                {
                    Console.WriteLine("ID: " + this.ID[i]);
                    Console.WriteLine("Name: " + this.Name[i]);
                    Console.WriteLine("College: " + this.CollegeName[i]);
                    Console.WriteLine("Course Enrolled: " + this.CourseEnrolled[i]);
                    Console.WriteLine("Instructor: " + this.Instructor[i]);
                    Console.WriteLine("--------------------------------------------------------------------\n");
                }
            }
            else
            {
                //catch error if there are no more students to remove
                Console.Write("\nNow, there are no more students to remove in our admin portal list.\n");
            }

        }

    }
}

