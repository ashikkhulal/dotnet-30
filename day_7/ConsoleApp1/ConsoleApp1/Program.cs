using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace day_7_lessons
{
    class Program
    {
        //day 7 topics:
        //c# interfaces
        //c# enum
        //c# exception: try / catch


        static void Main(string[] args)
        {
            //interface object
            //IAnimal dogObject1 = new Dog();
            //dogObject1.sound1();
            //IAnimalMultiple dogObject2 = new Dog();
            //dogObject2.sound2();

            //enum object
            //IAnimalMultiple enumObject = new Dog();
            //enumObject.enumUsage();

            //another direct enum usage example
            //Priority priority2 = Priority.Medium;   //syntax: <enum-class-name> <object-name> = <enum-class-name>.<enum-constant-name>
            //Console.WriteLine("Current priority is " + priority2);

            //exception object
            //ExceptionFirst exception = new ExceptionFirst();
            //exception.exceptionMethod();

            ExceptionSecond exception2 = new ExceptionSecond();
            exception2.exceptionMethod2();

        }

        //interface: another way to achieve abstraction in c# is with interfaces
        //interface is a completely "abstract class" which can only contain abstract methods and properties (empty bodies)
        //by default, members of an interface are abstract and public
        //no needs to use override keyword while implementing interfaces
        interface IAnimal   ////syntax: interface I<interface-name> {} | Also, it is a good coding convention to start with 'I' on the interface name
        {
            //regular interface method
            void sound1();    //interface method is always public and abstract
        }

        //multiple interfaces
        interface IAnimalMultiple
        {
            //regular interface method
            void sound2();

            //enum method
            void enumUsage();

        }

        interface IException
        {
            //c# exception method
            void exceptionMethod();

        }

        interface IException2
        {
            //c# exception method
            void exceptionMethod2();

        }


        class Dog : IAnimal, IAnimalMultiple //child class of inheritance
        {
            public void sound1()
            {
                Console.WriteLine("Dog sound!");
            }

            public void sound2()
            {
                Console.WriteLine("Bow, bow!");
            }

            //enum usage example
            Priority priority = Priority.High;
            public void enumUsage() 
            {
                Console.WriteLine("Current priority is " +  priority);
            }

        }

        //enum: special class that represent a group of constants

        enum Priority    //syntax: enum <enum-name> {}
        {
            High,
            Medium,
            Low
        }

        //c# exception: try/ catch/ finally
        //when executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
        //when an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

        //the try statement allows you to define a block of code to be tested for errors while it is being executed.
        //the catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
        //only one finally

        //syntax example
        //try 
        //{
        //    //block of code
        //}
        //catch (Exception e)
        //{
        //    //block of code
        //}
        //finally
        //{
        //    //block of code
        //}


        class ExceptionFirst : IException
        {
            public void exceptionMethod()
            {
                try
                {
                    int number = 10;
                    Console.WriteLine("Division of " + number + " by " + 0 + " is: " + number / 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }


        class ExceptionSecond : IException2
        {
            public void exceptionMethod2()
            {
                int number = 10;
                for (int i = 0; i <= number; i++) 
                {
                    try
                    {
                        Console.WriteLine("Division of " + number + " by " + i + " is: " + number / i);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                }

                //other types of exception
                //catch (FieldAccessException ex)
                //{
                //    Console.WriteLine(ex.Message);

                //}
                //catch (SystemException ex)
                //{
                //    Console.WriteLine(ex.Message);

                //}

                //finally
                //finally
                //{

                //}
            }
        }


    }
}