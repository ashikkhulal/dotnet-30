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

        //public int[] ID;
        //public string[] Name;
        //public string[] State;
        //public string[] CourseOffered;
        //public string[] Instructor;

        //private properties of college object
        //private int[] _ID = new int[] { 1, 2, 3, 4, 5 };
        //private string[] _Name = new string[] { "MA", "NJ", "MA", "CA", "CT" };
        //private string[] _State = new string[] { "Harvard University", "Princeton University", "Massachusetts Institute of Technology", "Stanford University", "Yale University" };
        //private string[] _CourseOffered = new string[] { "English", "Spanish", "Computer Science", "Maths", "Physics" };
        //private string[] _Instructor = new string[] { "John Doe", "Henry Thomas", "John King", "Abraham Lincoln", "John F Kennedy" };

        private int[] _ID;
        private string[] _Name;
        private string[] _State;
        private string[] _CourseOffered;
        private string[] _Instructor;

        //public properties of college object
        public int[] ID { get { return _ID; } set { _ID = value; } }
        public string[] Name { get { return _Name; } set { _Name = value; } }
        public string[] State { get { return _State; } set { _State = value; } }
        public string[] CourseOffered { get { return _CourseOffered; } set { _CourseOffered = value; } }
        public string[] Instructor { get { return _Instructor; } set { _Instructor = value; } }

        //new temp college properties for removal
        private int[] _tempID;
        private string[] _tempName;
        private string[] _tempState;
        private string[] _tempCourseOffered;
        private string[] _tempInstructor;

        //public properties of college object
        public int[] tempID { get { return _tempID; } set { _tempID = value; } }
        public string[] tempName { get { return _tempName; } set { _tempName = value; } }
        public string[] tempState { get { return _tempState; } set { _tempState = value; } }
        public string[] tempCourseOffered { get { return _tempCourseOffered; } set { _tempCourseOffered = value; } }
        public string[] tempInstructor { get { return _tempInstructor; } set { _tempInstructor = value; } }


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

        public void addCollegeName(int countAdd)
        {
            ID = new int[countAdd];
            Name = new string[countAdd];
            State = new string[countAdd];  
            CourseOffered = new string[countAdd];   
            Instructor = new string[countAdd];

            for (int i = 0; i <= countAdd - 1; i++)
            {
                Console.WriteLine("\nEnter the college details below for ID" + i + ":");
                Console.Write("ID: ");
                this.ID[i] = Convert.ToInt16(Console.ReadLine());
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

        public void removeCollegeName(int remove)
        {
            //gets the index to remove
            int indexToRemove = Array.IndexOf(_ID, remove);

            Console.WriteLine("\nYou want to remove below college details: \n");
            Console.WriteLine("--------------------------------------------------------------------\n");
            Console.WriteLine("ID: " + this.ID[remove - 1]);
            Console.WriteLine("Name: " + this.Name[remove - 1]);
            Console.WriteLine("State: " + this.State[remove - 1]);
            Console.WriteLine("Course Offered: " + this.CourseOffered[remove - 1]);
            Console.WriteLine("Instructor: " + this.Instructor[remove - 1]);
            Console.WriteLine("--------------------------------------------------------------------\n");
            
            Console.Write("Are you sure you want to delete it? Enter Y to confirm: ");
            string Confirm = Console.ReadLine();

            if (Confirm != "Y" || Confirm != "y") 
            {
                this.ID = this.ID.Where(e => e != ID(remove-1).ToArray();
                for (int  i = indexToRemove; i < _ID.Length; i++)
                {
                    
                    this._ID[i] = this._ID[i + 1];
                    this._Name[i] = this._Name[i + 1];
                    this._State[i] = this._State[i + 1];
                    this._CourseOffered[i] = this._CourseOffered[i + 1];
                    this._Instructor[i] = this._Instructor[i + 1];
                }

                //decrementing college private properties array sizes
                Array.Resize(ref _ID, _ID.Length-1);
                Array.Resize(ref _Name, _Name.Length-1);
                Array.Resize(ref _State, _State.Length-1);
                Array.Resize(ref _CourseOffered, _CourseOffered.Length-1);
                Array.Resize(ref _Instructor, _Instructor.Length-1);
            }

            Console.WriteLine("\nAfter deletion: ");

            Console.WriteLine("\n-------------------------- New College List ---------------------------");
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

    }
}
