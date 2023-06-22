namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            int selection;

            // print welcome dialogue
            Console.WriteLine("Welcome to a simple calculator!");
            Console.WriteLine("Give me two numbers and I will either add, subtract, multiply, or divide them for you.\n");

            // get two numbers from the user
            Console.Write("Enter your first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            // print what operation to perform
            Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");
            Console.Write("What operation would you like to perform? (Example 1 to add or 2 to subtract and so on: ");
            selection = Convert.ToInt16(Console.ReadLine());


            // if else if condition as per selection
            if (selection == 1)
            {
                double answer = firstNumber + secondNumber;
                Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber + " is: " + answer);
            }
            else if (selection == 2)
            {
                double answer = secondNumber - firstNumber;
                Console.WriteLine("Subtraction of " + firstNumber + " from " + secondNumber + " is: " + answer);
            }
            else if (selection == 3)
            {
                double answer = firstNumber * secondNumber;
                Console.WriteLine("Multiplication of " + firstNumber + " and " + secondNumber + " is: " + answer);
            }
            else if (selection == 4)
            {
                double answer = firstNumber / secondNumber;
                Console.WriteLine("Division of " + firstNumber + " by " + secondNumber + " is: " + answer);
            }
            else
            {
                Console.WriteLine("You entered an invalid choice! Try next time.");
            }

            Console.ReadKey();
        }
    }
}