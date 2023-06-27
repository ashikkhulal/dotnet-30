using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace collegeAdminApp
{
    class Program
    {

        //how many colleges you want to enter:
        //
        static void Main(string[] args)
        {

            //welcome dialogue and ascii screen
            WelcomeAndChoice welcomeObj = new WelcomeAndChoice();
            welcomeObj.welcomeDialogue();

            //empty string for while loop continuation
            string Continue = "";

            //while loop to repeat the program
            while (Continue != "N")
            {

                WelcomeAndChoice choiceObj = new WelcomeAndChoice();
                choiceObj.choiceMethod();

                int Choice = Convert.ToInt16(Console.ReadLine());
                WelcomeAndChoice conditionObj = new WelcomeAndChoice();
                conditionObj.conditionMethod(Choice);

                Console.Write("Enter Y to try again or N to exit the program: ");
                Continue = Console.ReadLine();
            }


            //reads user input key before termination of the program
            Console.ReadKey();
        }
        class WelcomeAndChoice
        {
            //conditions variable
            int Choice = new int();
            int AddOrRemove = new int();

            //welcomeDialogue method for a welcome screen
            public void welcomeDialogue()
            {
                Console.WriteLine(@"
                                               _ _.-'`-._ _
                                              ;.'________'.;
                                   _________n.[____________].n_________
                         |""""_""""_""""_""""||==||==||==||""""_""""_""""_""""]
                       |""""""""""""""""""""""||..||..||..||""""""""""""""""""""""|
                     |LI LI LI LI LI ||LI LI ||..COLLEGE .||LI LI LI LI||LI LI LI LI|
                     |LI LI LI LI LI ||LI LI ||.. ADMIN ..||LI LI LI LI||LI LI LI LI|
                     |LI LI LI LI LI ||LI LI ||.. PORTAL .||LI LI LI LI||LI LI LI LI|
                  ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,,,;;,;;;,;;;,;;,,;;,;;;,;;;,;;,
                ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,;;,;;;,;;;,;;,,;;,;;;,;;;,;;,
                        
                                    Welcome to the College Admin Portal!
                 ");

            }

            public void choiceMethod()
            {
                Console.WriteLine("\nWhat would you like to do? \n\n1. View Colleges\n2. View Students\n3. View Instructors\n4. Add/Remove a College\n5. Add/Remove a Student\n6. Add/Remove an Instructor\n");
                Console.Write("For example: enter 1 if you want to view colleges or enter 4 if you want to add/remove a college and so on: ");
            }


            //choice method
            public void conditionMethod(int option)
            {
                //conditions variable
                int AddOrRemove = new int();

                //college object
                College college = new College();

                //student object
                Student student = new Student();

                //instructor object
                Instructor instructor = new Instructor();

                //view colleges condition
                if (option == 1)
                {
                    Console.WriteLine("\nYou entered " + option);
                    college.getCollegeNames();


                }
                //view students condition
                else if (option == 2)
                {
                    Console.WriteLine("\nYou entered " + option);
                    
                    student.getStudentNames();

                }
                //view instructors condition
                else if (option == 3)
                {
                    Console.WriteLine("\nYou entered " + option);
                    instructor.getInstructorNames();

                }
                //add or remove college details
                else if (option == 4)
                {
                    Console.WriteLine("\nYou entered " + option);
                    Console.WriteLine("\nWhat would you like to do? \n1. Add a college\n2. Remove a college\n");
                    Console.Write("For example: enter 1 if you want to add colleges or enter 2 if you want to remove a college: ");
                    AddOrRemove = Convert.ToInt16(Console.ReadLine());
                    //condition to add a college
                    if (AddOrRemove == 1)
                    {
                        Console.WriteLine("\nYou entered " + AddOrRemove);
                        college.addCollegeName();
                    }
                    //condition to remove a college
                    else if (AddOrRemove == 2)
                    {
                        Console.WriteLine("\nYou entered " + AddOrRemove);
                        //shows college list
                        college.getCollegeNames();
                        Console.Write("Enter ID of the college you want to remove: ");
                        int GetID = Convert.ToInt16(Console.ReadLine());
                        college.removeCollegeName(GetID);
                        Console.WriteLine("\nAfter deletion: ");
                        college.getCollegeNames();
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid input!!!");
                    }

                }
                //add or remove student details
                else if (option == 5)
                {
                    Console.WriteLine("\nYou entered " + option);

                }
                //add or remove teacher details
                else if (option == 6)
                {
                    Console.WriteLine("\nYou entered " + option);

                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid input!!!");
                }
            }

        }


    }
}