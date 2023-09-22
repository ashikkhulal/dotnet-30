// Simple calculator (add, subtract, multiply, and divide) with the usage of class, method, objects and properties

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //myCalc object declaration
            Calculator myCalc = new Calculator();

            //calling welcomeDialogue method
            myCalc.welcomeDialogue();
            //setting FirstNumber property value by calling getFirstNumbers method
            myCalc.FirstNumber = myCalc.getFirstNumbers();
            //setting SecondNumber property value by calling SecondNumber method
            myCalc.SecondNumber = myCalc.getSecondNumbers();
            //setting Choice property value by calling operationChoice method
            myCalc.Choice = myCalc.operationChoice();
            //calling calculateAnswer method
            myCalc.calculateAnswer();

            Console.ReadKey();

        }

        //class calculator
        class Calculator
        {
            //private properties
            private double _FirstNumber;
            private double _SecondNumber;
            private int _Choice;
            private double _Answer;

            //public properties
            public double FirstNumber { get { return _FirstNumber; } set { _FirstNumber = value; } }
            public double SecondNumber { get { return _SecondNumber; } set { _SecondNumber = value; } }
            public int Choice { get { return _Choice; } set { _Choice = value; } }
            public double Answer { get { return _Answer; } set { _Answer = value; } }

            //welcomeDialogue method
            public void welcomeDialogue()
            {
                Console.WriteLine("Welcome to a simple calculator!");
                Console.WriteLine("Give me two numbers and I will either add, subtract, multiply, or divide them for you.\n");
            }

            //method to get and return first numbers from user
            public double getFirstNumbers()
            {
                Console.Write("Enter your first number: ");
                this.FirstNumber = Convert.ToDouble(Console.ReadLine());

                return FirstNumber;
            }

            //method to get and return second numbers from user
            public double getSecondNumbers()
            {
                Console.Write("Enter your Second number: ");
                this.SecondNumber = Convert.ToDouble(Console.ReadLine());

                return SecondNumber;
            }

            //method to get and return operation choice
            public int operationChoice()
            {
                Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");
                Console.Write("What operation would you like to perform? (Example 1 to add or 2 to subtract and so on: ");
                this.Choice = Convert.ToInt16(Console.ReadLine());

                return Choice;
            }

            //method to calculate and return answer
            public void calculateAnswer()
            {
                if (Choice == 1)
                {
                    Answer = FirstNumber + SecondNumber;
                    Console.WriteLine("You want to add " + FirstNumber + " and " + SecondNumber + ". And the answer is: " + Answer);
                }
                else if (Choice == 2)
                {
                    Answer = SecondNumber - FirstNumber;
                    Console.WriteLine("You want to subtract " + FirstNumber + " from " + SecondNumber + ". And the answer is: " + Answer);
                }
                else if (Choice == 3)
                {
                    Answer = FirstNumber * SecondNumber;
                    Console.WriteLine("You want to multiply " + FirstNumber + " and " + SecondNumber + ". And the answer is: " + Answer);
                }
                else if (Choice == 4)
                {
                    Answer = FirstNumber / SecondNumber;
                    Console.WriteLine("You want to divide " + FirstNumber + " by " + SecondNumber + ". And the answer is: " + Answer);
                }
                else
                {
                    Console.WriteLine("You entered an invalid choice! Try next time.");
                    
                }
            }
        }
    }
}