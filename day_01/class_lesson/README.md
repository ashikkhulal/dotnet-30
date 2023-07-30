# Day 1 

Day 1 Topic(s) is / are:

- Syllabus
- C# introduction
- C# keywords
- Console application introduction


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