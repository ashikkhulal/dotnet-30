# Day 2

Day 2 topics are:

1. Variables
2. Data-types
3. String cOncatenation
4. Print output
5. User input into variables
6. Data type conversion

```
Pro-Tip/ Shortcuts for VS:

Ctrl + L : remove current line
Ctrl + D : Duplicate current line
Ctrl + K + C : comment block
Ctrl + K + U : uncomment block
Ctrl + K + D : fix formatting
Shift + Alt + Enter : focus mode
Ctrl + M + M : expand/ collapse block
Ctrl + M + O : expand/ collapse to definition
Ctrl + R + M : extracts (refactors a bunch of codes) to method
Ctrl + K + S : Surrounds the block of code
Ctrl + R + R : rename method/ variable all the way
Ctrl + R + G : organizes using references
Ctrl + Enter : Add a line above
Ctrl + Shift + Enter : Add a line below
F12 : go to definition
Shift + F12 : find all references
ctor + Tab + Tab : generate constructor
foreach + Tab + Tab : generate foreach loop
for + Tab + Tab : generate for loop
sw + Tab + Tab : generate switch statement
Alt + up / down : Move line (selected block) up/ down
```

## Variables:
A variable stores a value of the specific data type.
Syntax: 

```
<data-type> <variable_name> = <value>;
int num = 100;
```

The followings are naming conventions for declaring variables in C#:
1. Variable names must be unique.
2. Variable names can contain letters, digits, and the underscore _ only.
3. Variable names must start with a letter.
4. Variable names are case -sensitive, num and Num are considered different names.
5. Variable names cannot contain reserved keywords. Must prefix @ before keyword if want reserve keywords as identifiers.

C# is a strongly-typed language. It means we must declare the type of a variable that indicates the kind of values it is going to store, such as integer, float, decimal, text, etc.

## Data-types:
C# mainly categorized data types in two types: Value types and Reference types.
Value types include simple types (such as int, float, bool, and char), enum types, struct types, and Nullable value types.
Reference types include class types, interface types, delegate types, and array types.

Predefined Data Types in C#:
C# includes some predefined value types and reference types. The following table lists predefined data types:

| Type | Description | Range | Suffix |
|:---|:---|:---|:---|
| byte | 8 - bit unsigned integer | 0 to 255 |  |
| sbyte | 8 - bit signed integer | -128 to 127 |  |
| short | 16 - bit signed integer | -32,768 to 32,767 |  |
| ushort | 16 - bit unsigned integer | 0 to 65,535 |  |
| int | 32 - bit signed integer | -2,147,483,648 to 2,147,483,647 |  |
| uint | 32 - bit unsigned integer | 0 to 4,294,967,295 | u | |
| long | 64 - bit signed integer | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | l |
| ulong | 64 - bit unsigned integer | 0 to 18,446,744,073,709,551,615 | ul |
| float | 32 - bit Single - precision floating point type | -3.402823e38 to 3.402823e38 | f |
| double | 64 - bit double-precision floating point type | -1.79769313486232e308 to 1.79769313486232e308 | d |
| decimal | 128 - bit decimal type for financial and monetary calculations | (+or -)1.0 x 10e-28 to 7.9 x 10e28 | m |
| char | 16 - bit single Unicode character | Any valid character, e.g.a, *, \x0058(hex), or\u0058(Unicode)  |  |
| bool | 8 - bit logical true / false value | True or False  | |
| object | Base type of all other types |  |  |
| string | A sequence of Unicode characters |  |  |
| DateTime | Represents date and time | 0:00:00am 1 / 1 / 01 to 11:59:59pm 12 / 31 / 9999 |  |



