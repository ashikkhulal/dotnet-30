//References of .Net framework namespaces
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Namespace name
namespace day_1_lessons
{
    //Class name
	class Program
	{
        //Day 1 topics:
        //1. Syllabus
        //2. C# introduction
        //3. C# keywords
        //4. Console application introduction

        //Method
        static void Main(string[] args)
		{
            //data-type variable = value of variable
            string message = "Hello, World!";
            Console.WriteLine(message);
		}

        //Console application introduction

        //Let us understand the above C# structure:
        //1. Every .NET application takes the reference of the necessary .NET framework namespaces that it is planning to use with the using keyword, e.g., using System.Text.
        //2. Declare the namespace for the current class using the namespace keyword, e.g., namespace day_1_lessons
        //3. We then declared a class using the class keyword: class Program
        //4. The Main() is a method of Program class is the entry point of the console application.
        //5. String is a data type.
        //6. A message is a variable that holds the value of a specified data type.
        //7."Hello World!!" is the value of the message variable.
        //8. The Console.WriteLine() is a static method, which is used to display a text on the console.

        //Note: Every line or statement in C# must end with a semicolon (;).
    }

}