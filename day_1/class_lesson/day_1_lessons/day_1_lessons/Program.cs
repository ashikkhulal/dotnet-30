//references of .Net framework namespaces
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

//namespace name
namespace day_1_lessons
{
    //class name
	class Program
	{
        //C# Version History:
        //C# was first introduced with .NET Framework 1.0 in the year 2002 and evolved much since then. The following table lists important features introduced in each version of C#

        //Version	.NET Framework			Visual Studio				Important Features
        //C# 1.0	.NET Framework 1.0/1.1	Visual Studio .NET 2002		Basic features
        //C# 2.0    .NET Framework 2.0      Visual Studio 2005          Generics, Partial types, Anonymous methods, Iterators, Nullable types, Private setters(properties), Method group conversions(delegates), Covariance and Contra-variance, Static classes,
        //C# 3.0    .NET Framework 3.0\3.5  Visual Studio 2008          Implicitly typed local variables, Object and collection initializers, Auto-Implemented properties, Anonymous types, Extension methods, Query expressions, Lambda expressions, Expression trees, Partial Methods
        //C# 4.0    .NET Framework 4.0      Visual Studio 2010          Dynamic binding (late binding), Named and optional arguments, Generic co- and contravariance, Embedded interop types
        //C# 5.0    .NET Framework 4.5      Visual Studio 2012/2013	    Async features, Caller information
        //C# 6.0    .NET Framework 4.6      Visual Studio 2013/2015     Expression Bodied Methods, Auto-property initializer, nameof Expression, Primary constructor, Await in catch block, Exception Filter, String Interpolation
        //C# 7.0    .NET Core 2.0           Visual Studio 2017          out variables, Tuples, Discards, Pattern Matching, Local functions, Generalized async return types
        //C# 8.0    .NET Core 3.0           Visual Studio 2019          Readonly members, Default interface methods, Using declarations, Static local functions, Disposable ref structs, Nullable reference types
        //C# 9.0    .NET 5.0                Visual Studio 2019          Records, Init-only properties, Top-level statements, Init accessors and readonly fields, With-expressions, Value-based equality
        //C# 10.0	.NET 6.0                Visual Studio 2022          Record structs, Global using directives, File-scoped namespace declaration, Extended Proptery Patterns, Null Parameter Checking, Constant interpolated strings

        //C# can be used in a window-based, web-based, or console application. To start with, we will create a console application to work with C#.

        //method
        static void Main(string[] args)
		{
            //data-type variable = value of variable
            string message = "Hello, World!";
            Console.WriteLine(message);
		}

        //let's understand the above C# structure:
        //1. every .NET application takes the reference of the necessary .NET framework namespaces that it is planning to use with the using keyword, e.g., using System.Text.
        //2. declare the namespace for the current class using the namespace keyword, e.g., namespace CSharpTutorials.FirstProgram
        //3. we then declared a class using the class keyword: class Program
        //4. the Main() is a method of Program class is the entry point of the console application.
        //5. string is a data type.
        //6. a message is a variable that holds the value of a specified data type.
        //7."Hello World!!" is the value of the message variable.
        //8. The Console.WriteLine() is a static method, which is used to display a text on the console.

        //Note: Every line or statement in C# must end with a semicolon (;).
    }

}