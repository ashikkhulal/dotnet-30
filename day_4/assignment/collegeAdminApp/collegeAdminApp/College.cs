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
        //college is initialized with properties: ID, Name, States, CourseOffered, and Instructor

        //private properties of college object
        private int[] _ID = new int[] { 1, 2, 3, 4, 5 };
        private string[] _Name = new string[] { "MA", "NJ", "MA", "CA", "CT" };
        private string[] _State = new string[] { "Harvard University", "Princeton University", "Massachusetts Institute of Technology", "Stanford University", "Yale University" };
        private string[] _CourseOffered = new string[] { "English", "Spanish", "Computer Science", "Maths", "Physics" };
        private string[] _Instructor = new string[] { "John Doe", "Henry Thomas", "John King", "Abraham Lincoln", "John F Kennedy" };

        //public properties of college object
        public int[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] State { get { return _State; } set { _State = value; } }
        public string[] CourseOffered { get { return _CourseOffered; } set { _CourseOffered = value; } }
        public string[] Instructor { get { return _Instructor; } set { _Instructor = value; } }

        public void getCollegeNames()
        {
            Console.WriteLine("\n-------------------------- College List -----------------------------");
            for (int i = 0; i < ID.Length; i++)
            {
                Console.WriteLine("ID: " + this.ID[i]);
                Console.WriteLine("Name: " + this.Name[i]);
                Console.WriteLine("State: " + this.State[i]);
                Console.WriteLine("Course Offered: " + this.CourseOffered[i]);
                Console.WriteLine("Instructor: " + this.Instructor[i]);
                Console.WriteLine("--------------------------------------------------------------------\n");   
            }
        }

        public void addCollegeName()
        {
            int newValuePosition = ID.Length - 1;
            Console.WriteLine("\nEnter the college details below:");
            Console.Write("ID: ");
            this.ID[newValuePosition] = Convert.ToInt16(Console.ReadLine());
            Console.Write("Name: ");
            this.Name[newValuePosition] = Console.ReadLine();
            Console.Write("State: ");
            this.State[newValuePosition] = Console.ReadLine();
            Console.Write("Course Offered: ");
            this._CourseOffered[newValuePosition] = Console.ReadLine();
            Console.Write("Instructor: ");
            this.Instructor[newValuePosition] = Console.ReadLine();

            Console.WriteLine("\nYou added below college details: ");
            Console.WriteLine("ID: " + this.ID[newValuePosition]);
            Console.WriteLine("Name: " + this.Name[newValuePosition]);
            Console.WriteLine("State: " + this.State[newValuePosition]);
            Console.WriteLine("Course Offered: " + this.CourseOffered[newValuePosition]);
            Console.WriteLine("Instructor: " + this.Instructor[newValuePosition]);
            Console.WriteLine("--------------------------------------------------------------------\n");
        }

        public void removeCollegeName(int remove)
        {
            Console.WriteLine("\nYou want to remove below college details: ");
            Console.WriteLine("ID: " + this.ID[remove - 1]);
            Console.WriteLine("Name: " + this.Name[remove - 1]);
            Console.WriteLine("State: " + this.State[remove - 1]);
            Console.WriteLine("Course Offered: " + this.CourseOffered[remove - 1]);
            Console.WriteLine("Instructor: " + this.Instructor[remove - 1]);
            Console.WriteLine("--------------------------------------------------------------------\n");
            
            Console.Write("Are you sure you want to delete it? Enter Y to confirm: ");
            string Confirm = Console.ReadLine();
            if (Confirm != "Y") 
            {
                for (int  i = remove - 1; i < ID.Length; i++)
                {
                    ID[i] = ID[i + 1];
                    Name[i] = Name[i + 1];
                    State[i] = State[i + 1];
                    CourseOffered[i] = CourseOffered[i + 1];
                    Instructor[i] = Instructor[i + 1];
                }
            }
        }

    }
}
