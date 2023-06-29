using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_lesson
{
    class day_3
    {
        static void Main(string[] args)
        {
            //objects
            Car car = new Car(); //syntax: <class-Name> <object-Name> = <new(keyword)> <class-Name()>
            //car.Color = "Red";
            //car.Model = "Tesla";
            //car.Name = "Mycar";
            car.Start();
            car.setDetails();
            car.showDetails();

        }

        //class
        class Car
        {
            //types of classes:
            //public -- can be accessed from anywhere
            //private -- can be accessed from within the class only
            //protected -- can be accessed within the class and derived classes
            //internal -- can be accessed from the namespace

            //private properties | syntax: <access-modifier> <return-type> <property-Name> {} or <access-modifier> <return-type> <property-Name> { get {return <Name>; set {<Name> = value;} or <access-modifier> <return-type> <property-Name> { get; set; } (but this last one will be nullable)
            private string _Name;
            private string _Color;
            private string _Model;

            //public properties | syntax: <access-modifier> <return-type> <property-Name> {} or <access-modifier> <return-type> <property-Name> { get {return <Name>; set {<Name> = value;} or <access-modifier> <return-type> <property-Name> { get; set; } (but this last one will be nullable)
            public string Name { get { return _Name; } set { _Name = value; } }
            //public string Name { get { return Name + " Hot"; } set { Name = value; } } //appending extra value
            public string Color { get { return _Color; } set { _Color = value; } }
            public string Model { get { return _Model; } set { _Model = value; } }

            //Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
            //declare fields/variables as private
            //provide public get and set methods, through properties, to access and update the value of a private field

            //public method or function
            public int Start()  //syntax: <access-modifier> <return-type> <method-Name>
            {
                return 1;
            }

            public void showDetails()
            {
                //printing output of car details with a method
                Console.WriteLine("Car Details are as: ");
                Console.WriteLine("Name: " + this._Name);
                Console.WriteLine("Color: " + this._Color);
                Console.WriteLine("Model: " + this._Model);
            }


            public void setDetails()
            {
                //setting car details with a method
                Console.Write("Enter the Name of your car: ");
                this.Name = Console.ReadLine();
                Console.Write("Enter the Color of your car: ");
                this.Color = Console.ReadLine();
                Console.Write("Enter the Model of your car: ");
                this.Model = Console.ReadLine();
            }

        }
    }
}
