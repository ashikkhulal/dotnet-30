using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8_lesson
{
    class Program
    {
        //day 8 topics are:
        //c# user-defined exceptions
        //c# generics
        //c# collections
        //c# delegates

        static void Main(string[] args)
        {
            //generic class object
            //syntax: generic-class-name<datatype> generic-object-name = new generic-class-name<datatype>(message)
            //GenericClass<string> genericClassObject = new GenericClass<string>("I am a string");


            //stack:
            //sytnax: Stack<data-type> stack-object-name = new Stack<data-type>();
            //Stack<string> stack = new Stack<string>();
            ////adds element(push is to add an element)
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");

            //foreach (string s in stack)
            //{
            //    //outputs in LIFO order
            //    Console.WriteLine(s);
            //}
            ////outputs last element(peek in stack is to output an last element)
            //Console.WriteLine(stack.Peek());
            ////outputs last element(pop is to remove an last element)
            //Console.WriteLine(stack.Pop());

            ////dictionary:
            ////key has to be unique, but value can be non-unique
            ////syntax: Dictionary<key-data-type, value-data-type> dictionary-object-name = new Dictionary<key-data-type, value-data-type>();
            //Dictionary<int, string> dictionaryObject = new Dictionary<int, string>();
            ////adding multiple key value pairs
            //dictionaryObject.Add(1, "First");
            //dictionaryObject.Add(2, "Second");
            //dictionaryObject.Add(3, "Third");
            //dictionaryObject.Add(4, "Fourth");

            ////removing a key value pair
            //dictionaryObject.Remove(4);



        }

        //c# user-defined exceptions: c# allows to create user-defined or custom exceptions
        //to do this we need to inherit exception class
        //an exception can be raised manually by using the throw keyword. Any type of exceptions which is derived from Exception class can be raised using the throw keyword.

        //example

        //private static void PrintStudentName(Student std)
        //{
        //    if (std == null)
        //        throw new NullReferenceException("Student object is null.");

        //    Console.WriteLine(std.StudentName);
        //}

        //another example

        //class Student
        //{
        //    public int StudentID { get; set; }
        //    public string StudentName { get; set; }
        //}

        //[Serializable]
        //class InvalidStudentNameException : Exception
        //{
        //    public InvalidStudentNameException() { }

        //    public InvalidStudentNameException(string name)
        //        : base(String.Format("Invalid Student Name: {0}", name))
        //    {

        //    }
        //}

        //generics: means not specific to a particular data type.
        //generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.

        //examples

        //class DataStore<T> //syntax: class <class-name<T>>
        //{
        //    public T Data { get; set; }
        //}

        //class KeyValuePair<TKey, TValue>
        //{ 
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; }
        //}

        //class GenericClass<W>
        //{
        //    //constructor for the GenericClass class | must match the name of the class and cannot have a return type 
        //    public GenericClass(W msg) 
        //    {
        //        Console.Write(msg);
        //    }
        //}

        //c# collections: represents group of objects. It is a specialized classes that store series of values or objects.
        //array has size limit but collection does not
        //two types of collections available in C#: non-generic collections and generic collections.
        //in most cases, it is recommended to use the generic collections because they perform faster than non-generic collections and also minimize exceptions by giving compile-time errors.
        //generic collections are:

        //List: List<T> contains elements of specified type. It grows automatically as you add elements in it.
        //LinkedList: LinkedList<T> uses the concept of linked list. It allows us to insert and delete elements fastly. It has the flexibility on where to add the data.
        //Hashset: Hashset<T> contains non-duplicate elements. It eliminates duplicate elements.
        //Dictionary: Dictionary<TKey,TValue> contains key-value pairs.
        //SortedDictionary: similar as dictionary above by sorted key

        //non-generic collections are:

        //ArrayList: ArrayList stores objects of any type like an array. However, there is no need to specify the size of the ArrayList like with an array as it grows automatically.
        //Hashtable: Hashtable stores key and value pairs. It retrieves the values by comparing the hash value of the keys.
        //BitArray: BitArray manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0).

        //both(generic and non-generic collections) are:

        //Queue: Queue stores the values in FIFO style (First In First Out). It keeps the order in which the values were added. It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection. C# includes generic and non-generic Queue.
        //Stack: Stack stores the values in LIFO style (Last In First Out). It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. C# includes both, generic and non-generic Stack.
        //SortedList: SortedList stores key and value pairs. It automatically arranges elements in ascending order of key by default. C# includes both, generic and non-generic SortedList collection.


        //c# delegates: is a reference type data type that defines the method signature. You can define variables of delegate, just like other data type, that can refer to any method with the same signature as the delegate.

        //syntax: [access-modifier] delegate [return-type] [delegate-name] ([parameter-data-type] [parameter]);
        //example: public delegate int MyDelegate(string s);

    }
}