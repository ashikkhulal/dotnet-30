using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_lesson
{
    class Program
    {
        //day 6 lessons:
        //1. inheritance in c#
        //2. c# polymorphism
        //3. abstraction in c#

        
        static void Main(string[] args)
        {
            //inheritance objects

            //child object
            //ChildClass childObj = new ChildClass(); //--> type Base Class object with Child Class is possible
            //childObj.getDetails();

            //BaseClass baseObj = new ChildClass();   //--> type Base Class object with Child Class is possible
            ////ChildClass baseObj = new BaseClass(); //--> type Child Class object with Base Class is not possible
            ///

            //polymorphism and inheritance objects (regular)

            //Animal animalObj = new Animal();   //accesses parent(animal) class
            //animalObj.sound();

            //Dog dogObj1 = new Dog();   //accesses child(dog) class
            //dogObj1.sound();

            //Animal dogObj2 = new Dog();    //accesses parent(animal) class
            //dogObj2.sound();


            //polymorphism and inheritance objects (override)

            //Animal dogObj2 = new Dog();    //accesses child(dog) class since override
            //dogObj2.sound();

            //Donkey donkey1Obj = new Donkey();    //accesses child(donkey) class since override
            //donkey1Obj.sound();

            //Animal donkey2Obj = new Donkey();    //accesses parent(animal) class
            //donkey2Obj.sound();

        }

    }

    //inheritance in c#: inheriting fields and methods from one class to another | derived class (child) and base class (parent)

    //example

    //class BaseClass
    //{
    //    public string baseClassCarModel = "Ford";

    //    public void getDetails()
    //    {
    //        Console.WriteLine(this.baseClassCarModel);
    //    }

    //}

    //class ChildClass : BaseClass //syntax: <child-class-name> : <base-class-name>
    //{
    //    public string ChildClassCarModel;

    //}

    //if you don't want other classes to inherit from a class, use sealed keyword

    //example

    //sealed class BaseClass
    //{
    //    public string baseClassCarModel = "Ford";

    //    public void getDetails()
    //    {
    //        Console.WriteLine(this.baseClassCarModel);
    //    }

    //}

    //class ChildClass : BaseClass //syntax: <child-class-name> : <base-class-name>
    //{
    //    public string ChildClassCarModel;

    //}

    //polymorphism: means "many forms" and it occurs when we have many classes that are related to each other by inheritance

    //example

    //class BaseClass
    //{
    //    public string baseClassCarModel = "Ford";

    //    public void getDetails()
    //    {
    //        Console.WriteLine(this.baseClassCarModel);
    //    }

    //}

    //class ChildClass1 : BaseClass //syntax: <child-class-name> : <base-class-name>
    //{
    //    public string ChildClass1CarModel;

    //}

    //class ChildClass2 : BaseClass //syntax: <child-class-name> : <base-class-name>
    //{
    //    public string ChildClass2CarModel;

    //}

    //another example:

    //class Animal
    //{

    //    public void sound()
    //    {
    //        Console.WriteLine("Animal Sound");
    //    }

    //}

    //class Cat : Animal
    //{
    //    public void sound()
    //    {
    //        Console.WriteLine("Cat Sound");
    //    }

    //}

    //class Dog : Animal
    //{
    //    public void sound()
    //    {
    //        Console.WriteLine("Dog Sound");
    //    }

    //}

    //class Donkey : Animal
    //{
    //    public void sound()
    //    {
    //        Console.WriteLine("Donkey Sound");
    //    }

    //}

    //override base class: specify virtual keyword in method of base class and override keyword in method of child class(s)

    //example

    //class Animal
    //{

    //    public virtual void sound() //virtual keyword
    //    {
    //        Console.WriteLine("Animal Sound");
    //    }

    //}

    //class Cat : Animal
    //{
    //    public override void sound()    //override keyword
    //    {
    //        Console.WriteLine("Cat Sound");
    //    }

    //}

    //class Dog : Animal
    //{
    //    public override void sound()    //override keyword
    //    {
    //        Console.WriteLine("Dog Sound");
    //    }

    //}

    //class Donkey : Animal
    //{
    //    public void sound()    //no override keyword here
    //    {
    //        Console.WriteLine("Donkey Sound");
    //    }

    //}

    //abstraction: process of hiding certain details and showing only essential information to the user
    //abstract class: restricted class that cannot be used to create objects. So it must be inherited from. It can have both regular and abstract method.
    //abstract method: can only be used in an abstract class and it does not have a body. The body is provided by the derived class (inherited from)

    //example

    //abstract class BaseAbstractClass    //abstract base class
    //{
    //    abstract public void IAmAbstractMethod();   //abstract method

    //    public void IAmRegularMethod()  //regular base method
    //    {
    //        Console.WriteLine("I am a regular parent method.");
    //    }
    //}

    //class ChildAbstractClass : BaseAbstractClass    //abstract child class
    //{
    //    public override void IAmAbstractMethod()    //always needs overide keyword for abstract base method body
    //    {
    //        Console.WriteLine("I am an abstract method being inherited from parent class to child class.");
    //    }

    //    public void IAmRegularMethod()  //regular child method
    //    {
    //        Console.WriteLine("I am a regular child method.");
    //    }
    //}

}
