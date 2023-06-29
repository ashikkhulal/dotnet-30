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

            //WelcomeAndChoice object
            WelcomeAndChoice welcomeObj = new WelcomeAndChoice();
            welcomeObj.welcomeDialogue();

            //empty string for while loop continuation
            string Continue = "";

            //while loop to repeat the program
            while ( Continue != "N" || Continue != "n" )
            {

                WelcomeAndChoice choiceObj = new WelcomeAndChoice();
                choiceObj.addDialogue();

                int choice = Convert.ToInt16(Console.ReadLine());
                WelcomeAndChoice conditionObj = new WelcomeAndChoice();
                conditionObj.conditionMethod(choice);

                Console.Write("Enter Y to try again or N to exit the program: ");
                Continue = Console.ReadLine();
            }
        }
        class WelcomeAndChoice
        {
            //conditions variable
            int choice = new int();
            int addOrRemove = new int();
            int countAddCollege = new int();
            int countRemoveCollege = new int();

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

            public void addDialogue()
            {
                Console.WriteLine("\nWhat would you like to do? \n\n1. Add colleges\n2. Add students\n3. Add instructors\n");
                Console.Write("For example: enter 1 if you want to view colleges or enter 4 if you want to add/remove a college and so on: ");
            }

            public void removeDialogue()
            {
                Console.WriteLine("\nWhat would you like to do? \n\n1. Remove colleges\n2. Remove students\n3. Remove instructors\n");
                Console.Write("For example: enter 1 if you want to view colleges or enter 4 if you want to add/remove a college and so on: ");
            }


            //condition method
            public void conditionMethod(int option)
            {
                //conditions variable
                string confirmRemove;

                //college object
                College college = new College();

                //student object
                Student student = new Student();

                //instructor object
                Instructor instructor = new Instructor();

                int IsCollegeListEmpty = new int();

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

                //4. View college list\n5. View student list\n6. View instructor list\n

                //add/ remove colleges condition
                if (option == 1)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    //output add college dialogue
                    Console.WriteLine("Okay, now let us add some colleges in our admin portal.\n");

                    //get number of entries
                    Console.Write("How many entries (IDs) do you want to enter? (For example: enter 5 to add 5 entries): ");
                    countAddCollege = Convert.ToInt16(Console.ReadLine());

                    //calling add college method
                    college.addCollegeName(countAddCollege);
                    Console.WriteLine("\nPerfect! You added below colleges list:");
                    college.getCollegeNames();

                    //output remove college dialogue
                    Console.Write("Now, do also you want to remove college? Enter Y for yes or N for No: ");
                    confirmRemove = Console.ReadLine();
                    
                    //condition to add a college
                    if (confirmRemove == "Y" || confirmRemove == "y" )
                    {
                        //output choice
                        Console.WriteLine("\nYou entered selection " + confirmRemove + "(Yes).");
                        Console.WriteLine("Okay, let us remove college(s) from our admin portal list.");
                        string continueRemoval = "";

                        //loop to repeat college removal step
                        while ( continueRemoval != "N" || continueRemoval != "n" )
                        {
                            if ( countAddCollege > 0 )
                            {
                                Console.Write("\nEnter ID of the college you want to remove: ");
                                int getID = Convert.ToInt16(Console.ReadLine());
                                college.removeCollegeName(getID);
                                countAddCollege--;

                                //output to ask if user wants to remove some more colleges
                                Console.Write("Do you want to remove any more college(s)? Enter Y to try again or N to exit the program: ");
                                continueRemoval = Console.ReadLine();

                            }
                            else
                            {
                                Console.Write("\nThere are no more colleges to remove in our admin portal list.");
                            }

                        }
                    }
                    //condition to remove a college
                    else if (addOrRemove == 2)
                    {

                        //gets college array size
                         IsCollegeListEmpty = college.ID.Length;

                        if (IsCollegeListEmpty == 0)
                        {
                            //output choice
                            Console.WriteLine("\nYou entered selection " + addOrRemove + ".");

                            Console.WriteLine("Nothing to remove! The college list is empty.");
                        }
                        else
                        {
                            //output choice
                            Console.WriteLine("\nYou entered selection " + addOrRemove + ".");

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
                    college.getCollegeNames();


                    ////check if list is empty or not
                    //if (IsCollegeListEmpty == 0)
                    //{
                    //    //output list is empty
                    //    Console.WriteLine("The college list is empty! Nothing to show.");
                    //}
                    //else
                    //{
                    //    //gets college list
                    //    college.getCollegeNames();
                    //}
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