using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    //Day 14 topic:
    //Revision of c#
    class Program
    {
        static void Main(string[] args)
        {
            ////writeline & write:

            //Console.WriteLine("      /|");
            //Console.WriteLine("     / |");
            //Console.WriteLine("    /  |");
            //Console.WriteLine("   /   |");
            //Console.WriteLine("  /____|");
            //Console.Write("Hello ");
            //Console.Write("World");

            ////Console.ReadLine();

            //// datatypes, variables and string concatenation & interpolation:

            //string characterName = "John";
            //int characterAge;
            //characterAge = 70; //late initialization

            //Console.WriteLine("There once was a man named " + characterName); //concatenation
            //Console.WriteLine("He was " + characterAge + " years old");

            //characterName = "Ron";
            //Console.WriteLine($"He later changed his name to {characterName}"); //interpolation
            //Console.WriteLine($"But didn't like being {characterAge}");

            //string phrase = "Girrafe school";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.5;
            //bool isMale = false;


            ////string:
            //Console.WriteLine("Hello\nWorld");
            //Console.WriteLine("Hello\"World");

            //phrase = "Girrafe school" + " is a valid school!";

            //Console.WriteLine(phrase);
            //Console.WriteLine( phrase.Length );
            //Console.WriteLine( phrase.ToUpper() );
            //Console.WriteLine( phrase.Contains("school") );
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine( phrase.IndexOf("is") );
            //Console.WriteLine( phrase.Substring(15) );
            //Console.WriteLine( phrase.Substring(15, 2) );

            ////number:
            //float length = 20.20F;
            //double width = 50.0046;
            //decimal money = 100.00M;

            //Console.WriteLine( Math.Pow(3,2) );
            //Console.WriteLine( Math.Sqrt(36) );
            //Console.WriteLine( Math.Max(4, 90) );
            //Console.WriteLine( Math.Min(4, 90) );
            //Console.WriteLine( Math.Round(4.3) );

            ////readline (user input):

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}!");

            ////type conversion & calculator:
            //int num = Convert.ToInt32("45");

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num1 + num2);

            ////madlibs:

            //string color, pluralNoun, celebrity;

            //Console.WriteLine("Roses are {color}");
            //Console.WriteLine("{plural noun} are blue");
            //Console.WriteLine("I love {celebrity}\n");


            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity name: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine($"\nRoses are {color}");
            //Console.WriteLine($"{pluralNoun} are blue");
            //Console.WriteLine($"I love {celebrity}");

            //arrays:
            //int[] luckyNumbers = { 4, 8, 3, 15, 23, 99};

            //luckyNumbers[5] = 1000; 

            //Console.WriteLine(luckyNumbers[5]);

            //string[] friends = new string[5];
            //friends[0] = "Jim";
            //friends[1] = "Henry";
            //friends[2] = "Jennifer";

            //string[] names;

            //calling method:
            //SayHi("Ashik", 28);
            //SayHi("Ram", 50);
            //SayHi("John", 16);

            //Console.WriteLine(Cube(5));

            ////if conditions:
            //bool isMale = true;
            //bool isTall = true;

            //// && = And 
            //// || = or 
            //// ! = not 
            //// > 
            //// < 
            //// >= 
            //// <=
            //// ==
            //// !=

            //if(isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male.");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male.");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall person.");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall or both.");
            //}

            //Console.WriteLine($"{GetMax(2, 10, 20)} is bigger");

            ////switch statement:
            //Console.Write("Enter a number from 1 to 7 and I will return you the day of the week: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetDay(num));

            ////while loop:
            //int index = 1;

            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);

            ////guessing game:
            //string secretWord = "giraffe";
            //string guess = "";

            //while(guess != secretWord)
            //{
            //    Console.Write("Enter a guess: ");
            //    guess = Console.ReadLine();
            //}
            //Console.WriteLine("You won!");

            ////for loop:
            //for (int i = 0; i <=5;  i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////power exponential 
            //Console.WriteLine(GetPow(3, 0));

            ////2D array:
            //int[,] numberGrid = {
            //    { 1, 2},
            //    { 5, 6},
            //    { 9, 10}
            //};

            //Console.WriteLine(numberGrid[1,1]);

            //int[,] anotherGrid = new int[2,3];

            //exception handling:
            //try
            //{
            //    Console.Write("enter a number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("enter another number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);           
            //}
            //finally
            //{
            //    Console.WriteLine("This always executes!");
            //}

            //classes objects, constructors, inheritance:
            //Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            //Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

        }

        ////methods:
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine($"Hello, {name}! You are {age} years old.");
        //}

        //static int Cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;

        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }


        //    return result;
        //}

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 1: 
        //            dayName = $"{dayNum} is Sunday!";
        //            break;
        //        case 2:
        //            dayName = $"{dayNum} is Monday!";
        //            break;
        //        case 3:
        //            dayName = $"{dayNum} is Tueday!";
        //            break;
        //        case 4:
        //            dayName = $"{dayNum} is Wednesday!";
        //            break;
        //        case 5:
        //            dayName = $"{dayNum} is Thursday!";
        //            break;
        //        case 6:
        //            dayName = $"{dayNum} is Friday!";
        //            break;
        //        case 7:
        //            dayName = $"{dayNum} is Saturday!";
        //            break;
        //        default:
        //            dayName = "You entered an invalid message";
        //            break;
        //    }

        //    return dayName;
        //}

        ////exponential method
        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result* baseNum;
        //    }

        //    return result;
        //}


    }
}