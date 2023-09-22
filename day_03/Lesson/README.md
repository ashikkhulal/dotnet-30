# DAY-3

Day 3 Topics are:

- Class
- Objects
- Namespace
- Encapsulation
- Methods/ functions

## Class:

❗ **Class** is a **blueprint.** 

A class is like a blueprint of a specific object that has certain attributes and features. For example, a car should have some attributes such as four wheels, two or more doors, steering, a windshield, etc. It should also have some functionalities like start, stop, run, move, etc. Now, any object that has these attributes and functionalities is a car. Here, the car is a class that defines some specific attributes and functionalities. Each individual car is an object of the car class. You can say that the car you are having is an object of the car class.

Likewise, in object-oriented programming, a class defines some properties, fields, events, methods, etc. A class defines the kinds of data and the functionality their objects will have.

A class can contain one or more constructors, fields, methods, properties, delegates, and events. They are called class members. A class and its members can have access modifiers such as public, private, protected, and internal, to restrict access from other parts of the program.

Types of classes:
**Public** -- can be accessed from anywhere
**Private** -- can be accessed from within the class only
**Protected** -- can be accessed within the class and derived classes
**Internal** -- can be accessed from the namespace

- **Field**: A class can have one or more fields. It is a class-level variable that holds a value. Generally, field members should have a private access modifier used with property. (Private Property)

```
Syntax: <access-modifier> <return-type> <property-Name> {} 
                                or
<access-modifier> <return-type> <property-Name> { get {return <Name>}; set {<Name> = value;} }
                                or
<access-modifier> <return-type> <property-Name> { get; set; } (but this one will be nullable)
```

- **Property:** A property encapsulates a private field using setter and getter to assign and retrieve underlying field value. (Public Property)
```
Syntax: <access-modifier> <return-type> <property-Name> {} 
                                or 
<access-modifier> <return-type> <property-Name> { get {return <Name>}; set {<Name> = value;} }
                                or 
<access-modifier> <return-type> <property-Name> { get; set; } (but this one will be nullable)

```

- **Method:** A method can contain one or more statements to be executed as a single unit. A method may or may not return a value. A method can have one or more input parameters.
```
Syntax: [access-modifier] return-type MethodName(type parameterName1, type parameterName2,...) {}
```
- **Constructor**: A constructor is a special type of method which will be called automatically when you create an instance of a class. A constructor is defined by using an access modifier and class name.
``` 
Syntax: <access-modifier> <class-name>(){ }

- A constructor name must be the same as a class name.
- A constructor can be public, private, or protected.
- The constructor cannot return any value so cannot have a return type.
- A class can have multiple constructors with different parameters but can only have one parameterless constructor.
- If no constructor is defined, the C# compiler would create it internally.
```
  
## Objects of a Class:

❗ **Object** is an **instance of a class.**

You can create one or more objects of a class. Each object can have different values of properties and field but methods and events behaves the same.

In C#, an object of a class can be created using the new keyword and assign that object to a variable of a class type. For example, the following creates an object of the Student class and assign it to a variable of the Student type.

```
Student myStudent = new Student();

You can now access public members of a class using the object.MemberName notation.

mystudent.FirstName = "Steve";

You can create multiple objects of a class with different values of properties and fields.

Student myStudentAnother = new Student();
myStudentAnother.FirstName = "Bill"

```

## Namespace:

Namespaces play an important role in managing related classes in C#. The .NET Framework uses namespaces to organize its built-in classes. For example, there are some built-in namespaces in .NET such as System, System.Linq, System.Web, etc. Each namespace contains related classes.

❗ **Namespace** is a **container for classes and namespaces.**

The namespace also gives unique names to its classes thereby you can have the same class name in different namespaces.

Classes under the same namespace can be referred to as **namespace.classname** syntax. (Fully qualified name!)

To use classes under a namespace without the fully qualified name, import the namespace with the using keyword at the top of C# class file.

A namespace can contain other namespaces. Inner namespaces can be separated using (.).

## Encapsulation:
Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
- declare fields/variables as private
- provide public get and set methods, through properties, to access and update the value of a private field