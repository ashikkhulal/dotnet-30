using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Variables and data-types:

            //Syntax: <data-type> <variable_name> = <value>;

            int integer = -1;
            float iAmFloat = 1.0000f;
            double iAmDouble = 30.987;
            string firstName = "John";
            char iAmChar = 'a';
            const int constVar = 25; //Syntax: const <data-type> <variable_name> = <value>;

            //Numbers in C#
            byte b1 = 255;
            sbyte sb1 = -128;
            short s1 = -32768;
            ushort us1 = 65535;
            int i = -2147483648;
            int hex = 0x2F;
            long l1 = -9223372036854775808;


            float f1 = 123456.5F;
            double d1 = 12345678912345.5d;
            decimal d1 = 123456789123456789123456789.5m;

            //C# Strings
            string text = "This is a string.";

            //Invalid: string text = "This is a "string" in C#.";

            string text = "This is a \"string\" in C#.";

            string str = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";

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

            //assigns default value 01/01/0001 00:00:00
            DateTime dt0 = new DateTime();

            //assigns year, month, day
            DateTime dt00 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt000 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt0000 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            DateTime dt = new DateTime(636370000000000000);
            DateTime.MinValue.Ticks;  //min value of ticks
            DateTime.MaxValue.Ticks; // max value of ticks

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            DateTime dt = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM

            DateTime dt1 = new DateTime(2015, 12, 31);
            DateTime dt2 = new DateTime(2016, 2, 2);
            TimeSpan result = dt2.Subtract(dt1);//33.00:00:00

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);
            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True

            //Example: late initialization
            int num;
            num = 100;

            int a = 10;
            a = 20;

            int i, j = 10, k = 20;

            int x = 0,
            y = 10,
            z = 20;

            int k = 100;
            int l = k;

            //Implicitly-type variables:

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

            //Example: Implicit Conversion
            int i = 345;
            float f = i;

            //Example: Explicitly Conversion
            Console.WriteLine(""); // prints empty line
            Console.WriteLine("Data type conversion examples:");
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt16(Console.ReadLine()); // converting string to int type for age value
            Console.WriteLine("You are " + age + " years old.");

            //Hold/Stop execution of program until the user presses a key:
            Console.ReadKey();
        }

        //Struct
        struct Coordinate
        {
            public int x;
            public int y;
        }

        //constructors in struct
        struct Coordinate2
        {
            public int x;
            public int y;

            public Coordinate2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
