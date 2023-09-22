//day 4 Class
namespace day_4_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //type casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            //conditions: a < b | a <=b | a > b | a >= b | a == b | a !=b
            //if statements: if | else | else if | switch
            //note: conditions need same data types for comparision
            //while loop
            //doWhile loop
            //for loop
            //foreach loop

            Loops forLoopObj = new Loops();
            //forLoopObj.forLoop();
            Loops forEachObj = new Loops();
            //forEachObj.forEachLoop();
            Loops ifStatementObj = new Loops();
            //ifStatementObj.ifStatement();
            Loops switchStatementObj = new Loops();
            //switchStatementObj.switchStatement();
            Loops doWhileLoopObj = new Loops();
            //doWhileLoopObj.doWhileLoop();

        }

        class Loops
        {
            //for loop example
            public void forLoop()
            {
                Console.Write("Enter a number from 1 to 20 to iterate: ");
                int flag = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("It will iterate until it reaches " + (flag - 1));
                //for (int i = 0; i < 10; i++)
                for (int i = 0; i < flag; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
            //foreach loop example
            public void forEachLoop()
            {
                //arrays are collections of values of same data types
                //string[] array = { "Tesla", "Volvo", "BMW", "Maruti", "Toyota", "Mercedes" };
                string[] array = new string[5];
                array[0] = "Tesla";
                array[1] = "Volvo";
                array[2] = "BMW";
                array[3] = "Maruti";
                array[4] = "Toyota";
                array[5] = "Mercedes";

                Console.WriteLine("It will iterate all the elements in the variable array");
                foreach (string s in array)
                {
                    Console.WriteLine(s);
                }
            }

            //if statement example
            public void ifStatement()
            {
                Console.Write("Enter either 1 or 2: ");
                int Choice = Convert.ToInt16(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine("You entered " + Choice);
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("You entered " + Choice);
                }
                else
                {
                    Console.WriteLine("You entered an invalid choice! Try next time.");

                }
            }

            //switch statement example
            public void switchStatement()
            {
                Console.Write("Enter either 1 or 2: ");
                int Choice = Convert.ToInt16(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("You entered " + Choice);
                        break;
                    case 2:
                        Console.WriteLine("You entered " + Choice);
                        break;
                    default:
                        Console.WriteLine("You entered an invalid choice! Try next time.");
                        break;
                   
                }
            }

            //doWhile loop example
            public void doWhileLoop ()
            {
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i < 10);
            }
        }

    }
}