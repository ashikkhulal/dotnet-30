using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            //Arrays continued
            //Multidimensional arrays -- matrix arrays -- row * column
            //int[,] arr2D = new int[3, 3]; //int[3--> row size, 3--> column size]
            //int[,] arrXD = { { 1, 8, 4, 6 }, { 5, 10, 9, 16 } };

            ////object
            //MDAClass MDAObject = new MDAClass();
            //MDAObject.MDAMethod(arrXD);


            //Jagged arrays -- arrays of arrays
            //int[][] jaggedArr = new int[2][];   //int[2--> number of arrays][]
            //jaggedArr[0] = new int[] { 10, 20, 30, 40 };
            //jaggedArr[1] = new int[] { 10, 20, 30, 40, 50, 60 };


            //JAClass JAObject = new JAClass();
            //JAObject.JAMethod(jaggedArr);

            //JAClass JAParametrizedObject = new JAClass("test");
            //JAParametrizedObject.JAParametrizedMethod(jaggedArr);

            //Console.Read();

        }


        //class MDAClass
        //{

        //    public void MDAMethod(int[,] arr)
        //    {
        //        //int[,] arrXD = { { 1, 8, 4, 6 }, { 5, 10, 9, 16 } };
        //        //Console.WriteLine(arrXD[0, 1]); //arrXD[0--> subset/row position, 1--> position inside specified row/subset]

        //        for (int i = 0; i < arr.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < arr.GetLength(1); j++)
        //            {
        //                Console.WriteLine(arr[i, j]);
        //            }
        //        }
        //    }
        //}

        //Pro-tip: Shift + F9 to get quickwatch window

        //class JAClass
        //{
        //    public void JAMethod(int[][] arr)
        //    {
        //        //int[,] arrXD = { { 1, 8, 4, 6 }, { 5, 10, 9, 16 } };
        //        //Console.WriteLine(arrXD[0, 1]); //arrXD[0--> subset/row position, 1--> position inside specified row/subset]

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr[i].Length; j++)
        //            {
        //                Console.WriteLine(arr[i][j] + " ");
        //            }
        //        }
        //    }
        //}



        //C# constructors: a special method to initialize objects
        //class Car
        //{
        //    public string model; //create a field

        //    //class constructor for the Car class | must match the name of the class and cannot have a return type
        //    public Car()
        //    {
        //        model = "Tesla"; //sets the initial value for the model
        //    }
        //}

        //class JAClass
        //{

        //    public string myField1;
        //    public string myField2;

        //    public JAClass()
        //    {
        //        myField1 = "I am a set by constructor";
        //    }

        //    public JAClass(string myfield) //parametrized constructor
        //    {
        //        myField2 = myfield;
        //    }

        //    public void JAMethod(int[][] arr)
        //    {
        //        //int[,] arrXD = { { 1, 8, 4, 6 }, { 5, 10, 9, 16 } };
        //        //Console.WriteLine(arrXD[0, 1]); //arrXD[0--> subset/row position, 1--> position inside specified row/subset]

        //        //for (int i = 0; i < arr.Length; i++)
        //        //{
        //        //    for (int j = 0; j < arr[i].Length; j++)
        //        //    {
        //        //        Console.WriteLine(arr[i][j] + " ");
        //        //    }
        //        //}
        //        Console.WriteLine(this.myField1);
        //    }

        //    public void JAParametrizedMethod(int[][] arr)
        //    {
        //        //int[,] arrXD = { { 1, 8, 4, 6 }, { 5, 10, 9, 16 } };
        //        //Console.WriteLine(arrXD[0, 1]); //arrXD[0--> subset/row position, 1--> position inside specified row/subset]

        //        //for (int i = 0; i < arr.Length; i++)
        //        //{
        //        //    for (int j = 0; j < arr[i].Length; j++)
        //        //    {
        //        //        Console.WriteLine(arr[i][j] + " ");
        //        //    }
        //        //}
        //        Console.WriteLine(this.myField2);
        //    }
        //}


        //C# Destructors: is a special member function of a class that is executed whenever an object of its class goes out of scope
        //class Car
        //{
        //    public string model; //create a field

        //    //class constructor for the Car class | must match the name of the class and cannot have a return type
        //    public Car()
        //    {
        //        model = "Tesla"; //sets the initial value for the model
        //    }

        //    //destructor | starts with tilda(~) and same name as class
        //    ~Car()
        //    {
        //        Console.WriteLine("I am a destructor");
        //    }
        //}
    }
}