using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace collegeAdminApp
{
    class Instructor
    {
        //instructor is initialized with properties: ID, Name, CollegeName, CourseTeaching, and StudentName

        //private properties of instructor
        private string[] _ID;
        private string[] _Name;
        private string[] _CollegeName;
        private string[] _CourseTeaching;
        private string[] _StudentName;

        //public properties of instructor
        public string[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] CollegeName { get { return _CollegeName; } set { _CollegeName = value; } }
        public string[] CourseTeaching { get { return _CourseTeaching; } set { _CourseTeaching = value; } }
        public string[] StudentName { get { return _StudentName; } set { _StudentName = value; } }


        //method to get instructors name
        public void getInstructorName()
        {
            Console.WriteLine("\n-------------------------- Instructor List -----------------------------");
            for (int i = 0; i < this.ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("College: " + this.CollegeName[i]);
                Console.WriteLine("Course Teaching: " + this.CourseTeaching[i]);
                Console.WriteLine("Student Name: " + this.StudentName[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
        }

        //method to add instructors name
        public void addInstructorName(int countAdd)
        {
            this.ID = new string[countAdd];
            this.Name = new string[countAdd];
            this.CollegeName = new string[countAdd];
            this.CourseTeaching = new string[countAdd];
            this.StudentName = new string[countAdd];

            for (int i = 0; i < countAdd; i++)
            {
                Console.WriteLine("\nEnter the instructor details below for ID" + i + ":");
                Console.Write("ID: ");
                this.ID[i] = Console.ReadLine();
                Console.Write("Name: ");
                this.Name[i] = Console.ReadLine();
                Console.Write("College: ");
                this.CollegeName[i] = Console.ReadLine();
                Console.Write("Course Teaching: ");
                this.CourseTeaching[i] = Console.ReadLine();
                Console.Write("Student Name: ");
                this.StudentName[i] = Console.ReadLine();
            }
        }

        //method to remove instructors name
        public void removeInstructorName(string remove)
        {
            //capture the index of the ID user wants to remove in index variable
            int index = Array.IndexOf(ID, remove);

            //output removal instructor details
            Console.WriteLine("\nYou want to remove below instructor details: \n");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("ID: " + this.ID[index]);
            Console.WriteLine("Name: " + this.Name[index]);
            Console.WriteLine("College: " + this.CollegeName[index]);
            Console.WriteLine("Course Teaching: " + this.CourseTeaching[index]);
            Console.WriteLine("Student Name: " + this.StudentName[index]);
            Console.WriteLine("--------------------------------------------------------------------");

            //confirm removal
            Console.Write("Are you sure you want to delete it? Enter Y/y to confirm: ");
            string Confirm = Console.ReadLine();

            //condition if user confirms to remove the instructor
            if (Confirm != "Y" || Confirm != "y")
            {
                //removing ID array using where clause
                this.ID = this.ID.Where(e => e != this.ID[index]).ToArray();

                //removing Name array using where clause
                this.Name = this.Name.Where(e => e != this.Name[index]).ToArray();

                //removing CollegeName array using where clause
                this.CollegeName = this.CollegeName.Where(e => e != this.CollegeName[index]).ToArray();

                //removing CourseTeaching array using where clause
                this.CourseTeaching = this.CourseTeaching.Where(e => e != this.CourseTeaching[index]).ToArray();

                //removing StudentName array using where clause
                this.StudentName = this.StudentName.Where(e => e != this.StudentName[index]).ToArray();
            }

            if (this.ID.Length > 0)
            {
                //output new instructor list
                Console.WriteLine("\nAfter deletion: ");
                Console.WriteLine("\n-------------------------- New Instructor List ---------------------------");
                for (int i = 0; i < this.ID.Length; i++)
                {
                    Console.WriteLine("ID: " + this.ID[i]);
                    Console.WriteLine("Name: " + this.Name[i]);
                    Console.WriteLine("College: " + this.CollegeName[i]);
                    Console.WriteLine("Course Teaching: " + this.CourseTeaching[i]);
                    Console.WriteLine("Student Name: " + this.StudentName[i]);
                    Console.WriteLine("--------------------------------------------------------------------\n");
                }
            }
            else
            {
                //catch error if there are no more instructors to remove
                Console.Write("\nNow, there are no more instructors to remove in our admin portal list.\n");
            }

        }

    }
}
