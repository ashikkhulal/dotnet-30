namespace myFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // data types:
            // variable defining pattern is: <type> <variable_name>

            int integer = -1;
            float iAmFloat = 1.0000f;
            double iAmDouble = 30.987;
            string firstName = "John";
            char iAmChar = 'a';
            const int constVar = 25; // const <type> <variable_name>


            // printing outputs and string concatenation:
            Console.WriteLine("Data types examples:");
            Console.WriteLine("integer is an integer type and its value is: " + integer);
            Console.WriteLine("iAmFloat is a float type and its value is: " + iAmFloat);
            Console.WriteLine("iAmDouble is a double type and its value is: " + iAmDouble);
            Console.WriteLine("firtsName is a string type and its value is: " + firstName);
            Console.WriteLine("iAmChar is a char and its value is: " + iAmChar);
            Console.WriteLine("constVar is a constant variable type and its value is: " + constVar);


            // reading values from console:
            Console.WriteLine(""); // prints empty line
            Console.WriteLine("Input values examples:");
            Console.Write("Enter a string input: "); // Console.Write() vs Console.WriteLine() is same line vs next line
            string userInput;
            userInput = Console.ReadLine(); // takes the input value as a string
            Console.WriteLine("You entered: " + userInput);


            // data type conversion:
            Console.WriteLine(""); // prints empty line
            Console.WriteLine("Data type conversion examples:");
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt16(Console.ReadLine()); // converting string to int type for age value
            Console.WriteLine("You are " + age + " years old.");

            // hold/stop execution of program until the user presses a key:
            Console.ReadKey();


            // Shprtcut Tip: CTRL + L to delete a single line
            // Shprtcut Tip: CTRL + D to copy a line to one below
            // Shprtcut Tip: CTRL + K + C to comment
            // Shprtcut Tip: CTRL + K + U to comment
            // Shprtcut Tip: CTRL + K + D to format


            // assignment: enter two numbers and do MDAS



        }
    }
}