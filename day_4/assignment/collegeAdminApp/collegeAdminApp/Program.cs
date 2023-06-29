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
            int CountAdd = new int();
            int CountRemove = new int();

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
                Console.WriteLine("\nWhat would you like to do? \n\n1. Add/ Remove colleges\n2. Add/ Remove students\n3. Add/ Remove instructors\n4. View college list\n5. View student list\n6. View instructor list\n");
                Console.Write("For example: enter 1 if you want to view colleges or enter 4 if you want to add/remove a college and so on: ");
            }


            //condition method
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

                int IsCollegeListEmpty = 0;

                //gets student array size
                //static int studentArrayLength()
                //{
                //    Student studentsize = new Student();
                //    int StudentArrayLength = studentsize.ID.Length;

                //    return StudentArrayLength;
                //}

                ////gets instructor list size
                //static int instructorArrayLength()
                //{
                //    Instructor instructorsize = new Instructor();
                //    int InstructorArrayLength = instructorsize.ID.Length;

                //    return InstructorArrayLength;
                //}

                //add/ remove colleges condition
                if (option == 1)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    Console.WriteLine("What would you like to do? \n\n1. Add colleges\n2. Remove colleges\n");
                    Console.Write("Enter 1 if you want to add colleges or enter 2 if you want to remove a college: ");
                    AddOrRemove = Convert.ToInt16(Console.ReadLine());
                    
                    //condition to add a college
                    if (AddOrRemove == 1)
                    {
                        //output choice
                        Console.WriteLine("\nYou entered selection " + AddOrRemove + ".");

                        Console.Write("How many entries (IDs) do you want to enter? (For example: enter 5 to add 5 entries): ");
                        CountAdd = Convert.ToInt16(Console.ReadLine());
                        college.addCollegeName(CountAdd);
                        Console.WriteLine("\nYou added below colleges list:\n");
                        college.getCollegeNames();
                        IsCollegeListEmpty = CountAdd - 1;
                    }
                    //condition to remove a college
                    else if (AddOrRemove == 2)
                    {

                        //gets college array size
                         IsCollegeListEmpty = college.ID.Length;

                        if (IsCollegeListEmpty == 0)
                        {
                            //output choice
                            Console.WriteLine("\nYou entered selection " + AddOrRemove + ".");

                            Console.WriteLine("Nothing to remove! The college list is empty.");
                        }
                        else
                        {
                            //output choice
                            Console.WriteLine("\nYou entered selection " + AddOrRemove + ".");

                            //shows college list
                            college.getCollegeNames();
                            Console.Write("Enter ID of the college you want to remove: ");
                            int GetID = Convert.ToInt16(Console.ReadLine());
                            college.removeCollegeName(GetID);
                            Console.WriteLine("\nAfter deletion: ");
                            college.getCollegeNames();
                        }
                    }
                    else
                    {
                        //output error
                        Console.WriteLine("\nYou entered an invalid input!!!");
                    }

                }
                //add/remove students condition
                else if (option == 2)
                {
                    

                }
                //add/remove colleges condition
                else if (option == 3)
                {
                    

                }
                //view colleges list condition
                else if (option == 4)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    //gets college array size
                    

                    //check if list is empty or not
                    if (IsCollegeListEmpty == 0)
                    {
                        //output list is empty
                        Console.WriteLine("The college list is empty! Nothing to show.");
                    }
                    else
                    {
                        //gets college list
                        college.getCollegeNames();
                    }
                }
                //view students list condition
                else if (option == 5)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    student.getStudentNames();

                }
                //view instructors list condition
                else if (option == 6)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    instructor.getInstructorNames();

                }
                else
                {
                    //output error
                    Console.WriteLine("\nYou entered an invalid input!!!");
                }
            }



        }


    }
}