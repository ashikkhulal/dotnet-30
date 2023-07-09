using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day 2 topics are
            //1. Variables
            //2. Data-types
            //3. String cOncatenation
            //4. Print output
            //5. User input into variables
            //6. Data type conversion

            //Variables:
            //A variable stores a value of the specific data type.
            //Syntax: <data-type> <variable_name> = <value>;

            //Data types:
            //C# is a strongly-typed language. It means we must declare the type of a variable that indicates the kind of values it is going to store, such as integer, float, decimal, text, etc.
            
            //The following declares and initialized variables of different data types.

            int integer = -1;
            float iAmFloat = 1.0000f;
            double iAmDouble = 30.987;
            string firstName = "John";
            char iAmChar = 'a';
            const int constVar = 25; //Syntax: const <data-type> <variable_name> = <value>;

            //C# mainly categorized data types in two types: Value types and Reference types.
            //Value types include simple types (such as int, float, bool, and char), enum types, struct types, and Nullable value types.
            //Reference types include class types, interface types, delegate types, and array types.

            //Predefined Data Types in C#:
            //C# includes some predefined value types and reference types. The following table lists predefined data types:
            //Type	        Description	                                                    Range	                                                           Suffix
            //byte          8 - bit unsigned integer                                        0 to 255
            //sbyte         8 - bit signed integer                                          -128 to 127
            //short         16 - bit signed integer                                         -32,768 to 32,767
            //ushort        16 - bit unsigned integer                                       0 to 65,535
            //int           32 - bit signed integer                                         -2,147,483,648 to 2,147,483,647
            //uint          32 - bit unsigned integer                                       0 to 4,294,967,295                                                  u
            //long          64 - bit signed integer                                         -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807             l
            //ulong         64 - bit unsigned integer                                       0 to 18,446,744,073,709,551,615                                     ul
            //float         32 - bit Single - precision floating point type                 -3.402823e38 to 3.402823e38                                         f
            //double        64 - bit double-precision floating point type                   -1.79769313486232e308 to 1.79769313486232e308                       d
            //decimal       128 - bit decimal type for financial and monetary calculations  (+or -)1.0 x 10e-28 to 7.9 x 10e28 m
            //char          16 - bit single Unicode character                               Any valid character, e.g.a, *, \x0058(hex), or\u0058(Unicode)
            //bool          8 - bit logical true / false value  True or False
            //object        Base type of all other types.
            //string        A sequence of Unicode characters
            //DateTime      Represents date and time                                        0:00:00am 1 / 1 / 01 to 11:59:59pm 12 / 31 / 9999

            //Alias vs .NET Type
            //The predefined data types are alias to their .NET type(CLR class) name.The following table lists alias for predefined data types and related.NET class name.
            //Alias       .NET Type           Type
            //byte        System.Byte         struct
            //sbyte       System.SByte        struct
            //int         System.Int32        struct
            //uint        System.UInt32       struct
            //short       System.Int16        struct
            //ushort      System.UInt16       struct
            //long        System.Int64        struct
            //ulong       System.UInt64       struct
            //float       System.Single       struct
            //double      System.Double       struct
            //char        System.Char         struct
            //bool        System.Boolean      struct
            //object      System.Object       Class
            //string      System.String       Class
            //decimal     System.Decimal      struct
            //DateTime    System.DateTime     struct

            //The followings are naming conventions for declaring variables in C#:
            //1. Variable names must be unique.
            //2. Variable names can contain letters, digits, and the underscore _ only.
            //3. Variable names must start with a letter.
            //4. Variable names are case -sensitive, num and Num are considered different names.
            //5. Variable names cannot contain reserved keywords. Must prefix @ before keyword if want reserve keywords as identifiers.

            //Numbers in C#
            //Numbers, in general, can be divided into two types: Integer type and floating-point types.
            //Integer type numbers are whole numbers without decimal points. It can be negative or positive numbers.
            //Integer type numbers are positive or negative whole numbers without decimal points. C# includes four data types for integer numbers: byte, short, int, and long.
            byte b1 = 255;
            sbyte sb1 = -128;
            short s1 = -32768;
            ushort us1 = 65535;
            int i = -2147483648;
            int hex = 0x2F;
            long l1 = -9223372036854775808;

            //Floating - point type is numbers with one or more decimal points. It can be negative or positive numbers.
            //Floating-point numbers are positive or negative numbers with one or more decimal points. C# includes three data types for floating-point numbers: float, double, and decimal.
            float f1 = 123456.5F;
            double d1 = 12345678912345.5d;
            decimal d1 = 123456789123456789123456789.5m;

            //C# Strings
            //In C#, a string is a series of characters that is used to represent text. It can be a character, a word or a long passage surrounded with the double quotes ". The following are string literals.
            string text = "This is a string.";

            //String concatenation
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;


            //String interpolation
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            //Date & Time:
            //C# includes DateTime struct to work with dates and times.
            DateTime dt = new DateTime();   // assigns default value 01/01/0001 00:00:00

            //Variables can be declared first and initialized later.
            //Example: late initialization
            int num;
            num = 100;

            //The value of a variable can be changed anytime after initializing it.
            int a = 10;
            a = 20;

            //Multiple variables of the same data type can be declared and initialized in a single line separated by commas.
            int i, j = 10, k = 20;

            //Multiple variables of the same type can also be declared in multiple lines separated by a comma. The compiler will consider it to be one statement until it encounters a semicolon ;
            int x = 0,
                y = 10
                z = 20;

            //The value of a variable can be assigned to another variable of the same data type. However, a value must be assigned to a variable before using it.
            int k = 100;
            int l = k;

            //Implicitly-type variables:
            //C# 3.0 introduced var keyword to declare method level variables without specifying a data type explicitly.
            var u = 100; // implicitly typed local variable

            //The compiler will infer the type of a variable from the expression on the right side of the = operator. Above, var will be compiled as int.

            //Printing outputs and string concatenation:

            Console.WriteLine("Data types examples:");
            Console.WriteLine("integer is an integer type and its value is: " + integer);
            Console.WriteLine("iAmFloat is a float type and its value is: " + iAmFloat);
            Console.WriteLine("iAmDouble is a double type and its value is: " + iAmDouble);
            Console.WriteLine("firtsName is a string type and its value is: " + firstName);
            Console.WriteLine("iAmChar is a char and its value is: " + iAmChar);
            Console.WriteLine("constVar is a constant variable type and its value is: " + constVar);

            //Reading values from console:
            Console.WriteLine(""); // prints empty line
            Console.WriteLine("Input values examples:");
            Console.Write("Enter a string input: "); // Console.Write() vs Console.WriteLine() is same line vs next line
            string userInput;
            userInput = Console.ReadLine(); // takes the input value as a string
            Console.WriteLine("You entered: " + userInput);

            //Data-type conversion:
            //The values of certain data types are automatically converted to different data types in C#. This is called an implicit conversion
            //implicit conversion
            //Example: Implicit Conversion
            int i = 345;
            float f = i;

            //However, not all data types are implicitly converted to other data types. For example, int type cannot be converted to uint implicitly. It must be specified explicitly, as shown below.

            Console.WriteLine(""); // prints empty line
            Console.WriteLine("Data type conversion examples:");
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt16(Console.ReadLine()); // converting string to int type for age value
            Console.WriteLine("You are " + age + " years old.");

            //Hold/Stop execution of program until the user presses a key:
            Console.ReadKey();

            // Shortcut Tip: CTRL + L to delete a single line
            // Shortcut Tip: CTRL + D to copy a line to one below
            // Shortcut Tip: CTRL + K + C to comment
            // Shortcut Tip: CTRL + K + U to comment
            // Shortcut Tip: CTRL + K + D to format
        }
    }
}
