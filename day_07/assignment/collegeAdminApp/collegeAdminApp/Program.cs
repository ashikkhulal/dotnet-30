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

                Console.Write("Enter Y/y to try again or N/n to exit the program: ");
                Continue = Console.ReadLine();
            }
        }
        class WelcomeAndChoice
        {
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

                //condition to add/remove/view colleges
                if (option == 1)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    //output add college dialogue
                    Console.WriteLine("Okay, now let us add some colleges in our admin portal.\n");

                    //get number of entries
                    Console.Write("How many entries (IDs) do you want to enter? (For example: enter 5 to add 5 entries): ");
                    int countAddCollege = Convert.ToInt16(Console.ReadLine());

                    //calling add college method
                    college.addCollegeName(countAddCollege);
                    Console.WriteLine("\nPerfect! You added below colleges list:");
                    college.getCollegeNames();

                    //output remove college dialogue
                    Console.Write("Now, do also you want to remove college? Enter Y/y for yes or N/n for No: ");
                    confirmRemove = Console.ReadLine();

                    //condition to remove college(s)
                    if (confirmRemove == "Y" || confirmRemove == "y")
                    {
                        //output choice
                        Console.WriteLine("\nYou entered selection " + confirmRemove + "(Yes).");
                        Console.WriteLine("Okay, let us remove college(s) from our admin portal list.");
                        string continueRemoval = "";

                        //loop to repeat college removal step
                        while (continueRemoval != "N" || continueRemoval != "n" || countAddCollege > 0)
                        {
                            //get id of the college to remove
                            Console.Write("\nEnter ID of the college you want to remove: ");
                            string getID = Console.ReadLine();

                            //calling remove college method
                            college.removeCollegeName(getID);

                            //decreasing college list by 1
                            countAddCollege--;

                            //output to ask if user wants to remove some more colleges
                            Console.Write("Do you want to remove any more college(s)? Enter Y/y to try again or N/n to stop the college removal: ");
                            continueRemoval = Console.ReadLine();
                        }
                    }
                }
                //condition to add/remove/view students
                else if (option == 2)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    //output add student dialogue
                    Console.WriteLine("Okay, now let us add some students in our admin portal.\n");

                    //get number of entries
                    Console.Write("How many entries (IDs) do you want to enter? (For example: enter 5 to add 5 entries): ");
                    int countAddStudent = Convert.ToInt16(Console.ReadLine());

                    //calling add student method
                    student.addStudentName(countAddStudent);
                    Console.WriteLine("\nPerfect! You added below students list:");
                    student.getStudentNames();

                    //output remove student dialogue
                    Console.Write("Now, do also you want to remove student? Enter Y/y for yes or N/n for No: ");
                    confirmRemove = Console.ReadLine();

                    //condition to remove student(s)
                    if (confirmRemove == "Y" || confirmRemove == "y")
                    {
                        //output choice
                        Console.WriteLine("\nYou entered selection " + confirmRemove + "(Yes).");
                        Console.WriteLine("Okay, let us remove student(s) from our admin portal list.");
                        string continueRemoval = "";

                        //loop to repeat student removal step
                        while (continueRemoval != "N" || continueRemoval != "n" || countAddStudent > 0)
                        {
                            //get id of the student to remove
                            Console.Write("\nEnter ID of the student you want to remove: ");
                            string getID = Console.ReadLine();

                            //calling remove student method
                            student.removeStudentName(getID);

                            //decreasing student list by 1
                            countAddStudent--;

                            //output to ask if user wants to remove some more students
                            Console.Write("Do you want to remove any more student(s)? Enter Y/y to try again or N/n to stop the student removal: ");
                            continueRemoval = Console.ReadLine();
                        }
                    }
                }
                //condition to add/remove/view instructor
                else if (option == 3)
                {
                    //output choice
                    Console.WriteLine("\nYou entered selection " + option + ".");

                    //output add instructor dialogue
                    Console.WriteLine("Okay, now let us add some instructor in our admin portal.\n");

                    //get number of entries
                    Console.Write("How many entries (IDs) do you want to enter? (For example: enter 5 to add 5 entries): ");
                    int countAddInstructor = Convert.ToInt16(Console.ReadLine());

                    //calling add instructor method
                    instructor.addInstructorName(countAddInstructor);
                    Console.WriteLine("\nPerfect! You added below instructors list:");
                    instructor.getInstructorName();

                    //output remove instructor dialogue
                    Console.Write("Now, do also you want to remove instructor? Enter Y/y for yes or N/n for No: ");
                    confirmRemove = Console.ReadLine();

                    //condition to remove instructor(s)
                    if (confirmRemove == "Y" || confirmRemove == "y")
                    {
                        //output choice
                        Console.WriteLine("\nYou entered selection " + confirmRemove + "(Yes).");
                        Console.WriteLine("Okay, let us remove instructor(s) from our admin portal list.");
                        string continueRemoval = "";

                        //loop to repeat instructor removal step
                        while (continueRemoval != "N" || continueRemoval != "n" || countAddInstructor > 0)
                        {
                            //get id of the instructor to remove
                            Console.Write("\nEnter ID of the instructor you want to remove: ");
                            string getID = Console.ReadLine();

                            //calling remove instructor method
                            instructor.removeInstructorName(getID);

                            //decreasing instructor list by 1
                            countAddInstructor--;

                            //output to ask if user wants to remove some more instructors
                            Console.Write("Do you want to remove any more instructor(s)? Enter Y/y to try again or N/n to stop the instructor removal: ");
                            continueRemoval = Console.ReadLine();
                        }
                    }
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