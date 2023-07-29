# Day 1 

Day 1 Topic(s) is / are:

- Syllabus
- C# introduction
- C# keywords
- Console application introduction
- Class
- Objects
- Namespace

## Syllabus:

## C# Introduction:

C# was first introduced with .NET Framework 1.0 in the year 2002 and evolved much since then. The following table lists important features introduced in each version of C#:

|Version|.Net Framework|Visual Studio|Important Features|
|:---|:---|:---|:---|
| C# 1.0 | .NET Framework 1.0/1.1 | Visual Studio .NET 2002	| Basic feature
| C# 2.0 | .NET Framework 2.0 | Visual Studio 2005 | Generics, Partial types, Anonymous methods, Iterators, Nullable types, Private setters(properties), Method group conversions(delegates), Covariance and Contra-variance, Static classes,
| C# 3.0 | .NET Framework 3.0\3.5 | Visual Studio 2008 | Implicitly typed local variables, Object and collection initializers, Auto-Implemented properties, Anonymous types, Extension methods, Query expressions, Lambda expressions, Expression trees, Partial Methods
| C# 4.0 | .NET Framework 4.0 | Visual Studio 2010 | Dynamic binding (late binding), Named and optional arguments, Generic co- and contravariance, Embedded interop types
| C# 5.0 | .NET Framework 4.5 | Visual Studio 2012/2013	| Async features, Caller information
| C# 6.0 | .NET Framework 4.6 | Visual Studio 2013/2015 | Expression Bodied Methods, Auto-property initializer, nameof Expression, Primary constructor, Await in catch block, Exception Filter, String Interpolation
| C# 7.0 | .NET Core 2.0 | Visual Studio 2017 | out variables, Tuples, Discards, Pattern Matching, Local functions, Generalized async return types ...
| C# 8.0 | .NET Core 3.0 | Visual Studio 2019 | Readonly members, Default interface methods, Using declarations, Static local functions, Disposable ref structs, Nullable reference types ...
| C# 9.0 | .NET 5.0 | Visual Studio 2019 | Records, Init-only properties, Top-level statements, Init accessors and readonly fields, With-expressions, Value-based equality ...
| C# 10.0| .NET 6.0 | Visual Studio 2022 | Record structs, Global using directives, File-scoped namespace declaration, Extended Proptery Patterns, Null Parameter Checking, Constant interpolated strings ...

C# can be used in a window-based, web-based, or console application.

## C# Keywords:

C# contains reserved words that have special meaning for the compiler. These reserved words are called "keywords".
Keywords cannot be used as an identifier (name of a variable, class, interface, etc.)
Keywords in C# are distributed under the following categories:

A. **Modifier keywords**: they are specific keywords that indicate who can modify types and type members. Modifiers allow or prevent certain parts of programs from being modified by other parts.
Modifier keywords are: abstract, async, const, event, extern, new, override, partial, readonly, sealed, static, unsafe, virtual, volatile

B. **Access modifier keywords**: they are applied to the declaration of the class, method, properties, fields, and other members. They define the accessibility of the class and its members.
Access modifier keywords are: public, private, internal, protected

C. **Statement keywords**: they are related to program flow.
Statement keywords are: if, else, switch, case, do, for, foreach, in, while, break, continue, default, goto, return, yield, throw, try, catch, finally, checked, unchecked, fixed, lock

D. **Method parameter keywords**: these keywords are applied to the parameters of a method.
Method parameter keywords are: params, ref, out

E. **Namespace keywords**: these keywords are applied with namespace and related operators.
Namespace keywords are: using, . operator, :: operator, extern alias

F. **Operator keywords**: they perform miscellaneous actions.
Operator keywords are: as, await, is, new, sizeof, typeof, stackalloc, checked, unchecked

G. **Access keywords**: they are used to access the containing class or the base class of an object or class.
Access keywords are: base, this

H. **Literal keywords**: they apply to the current instance or value of an object.
Literal keywords are: null, false, true, value, void

I. **Type keywords**: they are used for data types.
Type keywords are: bool, byte, char, class, decimal, double, enum, float, int, long, sbyte, short, string, struct, uint, uling, ushort

J. **Contextual keywords**: these keywords are considered as keywords, only if used in specific contexts. They are not reserved and so can be used as names or identifiers.
Contextual keywords are: add, var, dynamic, global, set, value

K. **Query keywords**: query keywords are contextual keywords used in LINQ queries.
Query keywords are: from, where, select, group, into, orderby, join, let, in, on, equals, by, ascending, descending

## Console Application Introduction:

## Class:

❗ **Class** is a **blueprint.** 

A class is like a blueprint of a specific object that has certain attributes and features. For example, a car should have some attributes such as four wheels, two or more doors, steering, a windshield, etc. It should also have some functionalities like start, stop, run, move, etc. Now, any object that has these attributes and functionalities is a car. Here, the car is a class that defines some specific attributes and functionalities. Each individual car is an object of the car class. You can say that the car you are having is an object of the car class.

Likewise, in object-oriented programming, a class defines some properties, fields, events, methods, etc. A class defines the kinds of data and the functionality their objects will have.

A class can contain one or more constructors, fields, methods, properties, delegates, and events. They are called class members. A class and its members can have access modifiers such as public, private, protected, and internal, to restrict access from other parts of the program.

- **Field**: A class can have one or more fields. It is a class-level variable that holds a value. Generally, field members should have a private access modifier used with property. (Private Property)
- **Property:** A property encapsulates a private field using setter and getter to assign and retrieve underlying field value. (Public Property)
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

❗ **Object** is **an instance of a class.**

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

❗ **Namespace** is **a container for classes and namespaces.**

The namespace also gives unique names to its classes thereby you can have the same class name in different namespaces.

Classes under the same namespace can be referred to as **namespace.classname** syntax. (Fully qualified name!)

To use classes under a namespace without the fully qualified name, import the namespace with the using keyword at the top of C# class file.

A namespace can contain other namespaces. Inner namespaces can be separated using (.).