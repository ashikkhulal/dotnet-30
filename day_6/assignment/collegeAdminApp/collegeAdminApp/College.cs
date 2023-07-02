using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace collegeAdminApp
{
    class College
    {
        //college is initialized with properties: ID, Name, State, CourseOffered, and Instructor

        //private properties of college
        private string[] _ID;
        private string[] _Name;
        private string[] _State;
        private string[] _CourseOffered;
        private string[] _Instructor;

        //public properties of college
        public string[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] State { get { return _State; } set { _State = value; } }
        public string[] CourseOffered { get { return _CourseOffered; } set { _CourseOffered = value; } }
        public string[] Instructor { get { return _Instructor; } set { _Instructor = value; } }

        //method to get colleges name
        public void getCollegeNames()
        {
            Console.WriteLine("\n-------------------------- College List -----------------------------");
            for (int i = 0; i < this.ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("State: " + this.State[i]);
                Console.WriteLine("Course Offered: " + this.CourseOffered[i]);
                Console.WriteLine("Instructor: " + this.Instructor[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
        }

        //method to add colleges name
        public void addCollegeName(int countAdd)
        {
            this.ID = new string[countAdd];
            this.Name = new string[countAdd];
            this.State = new string[countAdd];
            this.CourseOffered = new string[countAdd];
            this.Instructor = new string[countAdd];

            for (int i = 0; i < countAdd; i++)
            {
                Console.WriteLine("\nEnter the college details below for ID" + i + ":");
                Console.Write("ID: ");
                this.ID[i] = Console.ReadLine();
                Console.Write("Name: ");
                this.Name[i] = Console.ReadLine();
                Console.Write("State: ");
                this.State[i] = Console.ReadLine();
                Console.Write("Course Offered: ");
                this.CourseOffered[i] = Console.ReadLine();
                Console.Write("Instructor: ");
                this.Instructor[i] = Console.ReadLine();
            }
        }

        //method to remove colleges name
        public void removeCollegeName(string remove)
        {
            //capture the index of the ID user wants to remove in index variable
            int index = Array.IndexOf(ID, remove);

            //output removal college details
            Console.WriteLine("\nYou want to remove below college details: \n");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("ID: " + this.ID[index]);
            Console.WriteLine("Name: " + this.Name[index]);
            Console.WriteLine("State: " + this.State[index]);
            Console.WriteLine("Course Offered: " + this.CourseOffered[index]);
            Console.WriteLine("Instructor: " + this.Instructor[index]);
            Console.WriteLine("--------------------------------------------------------------------");

            //confirm removal
            Console.Write("Are you sure you want to delete it? Enter Y/y to confirm: ");
            string Confirm = Console.ReadLine();

            //condition if user confirms to remove the college
            if (Confirm != "Y" || Confirm != "y")
            {
                //removing ID array using where clause
                this.ID = this.ID.Where(e => e != this.ID[index]).ToArray();

                //removing Name array using where clause
                this.Name = this.Name.Where(e => e != this.Name[index]).ToArray();

                //removing State array using where clause
                this.State = this.State.Where(e => e != this.State[index]).ToArray();

                //removing CourseOffered array using where clause
                this.CourseOffered = this.CourseOffered.Where(e => e != this.CourseOffered[index]).ToArray();

                //removing Instructor array using where clause
                this.Instructor = this.Instructor.Where(e => e != this.Instructor[index]).ToArray();
            }

            if (this.ID.Length > 0)
            {
                //output new college list
                Console.WriteLine("\nAfter deletion: ");
                Console.WriteLine("\n-------------------------- New College List ---------------------------");
                for (int i = 0; i < this.ID.Length; i++)
                {
                    Console.WriteLine("ID: " + this.ID[i]);
                    Console.WriteLine("Name: " + this.Name[i]);
                    Console.WriteLine("State: " + this.State[i]);
                    Console.WriteLine("Course Offered: " + this.CourseOffered[i]);
                    Console.WriteLine("Instructor: " + this.Instructor[i]);
                    Console.WriteLine("--------------------------------------------------------------------\n");
                }
            }
            else
            {
                //catch error if there are no more colleges to remove
                Console.Write("\nNow, there are no more colleges to remove in our admin portal list.\n");
            }

        }

    }
}

