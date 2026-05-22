# C# Complete Notes 🚀
## Beginner Friendly Notes Generated from Uploaded C# Files

---

# Introduction

These notes contain:
- Proper explanations
- Syntax
- Diagrams
- Real-world use cases
- Program flow
- OOP concepts
- Collections & Delegates

---


# File: 85da6444-8e72-436c-89d9-4ff49644070e.cs

## Concept Flow

```text
Input
  ↓
Method Execution
  ↓
Logic Processing
  ↓
Output
```

---

## Source Code

```csharp
### Day_05 Concepts of C#.

## What is Static?
=> In C#, the static keyword is used to declare members (fields, methods, properties) or classes that belong to the type itself rather than to a specific instance (object).

***Static Class***
=> Cannot be instantiated (you can't use new) and can only contain static members. It is implicitly "sealed".

***Static Method***
=> Can be called without creating an object. It can only access other static members directly.
1) No Instance Context: Non-static (instance) variables require an object to hold their values. A static method can be called using just the class name, meaning zero objects might exist in memory at that moment.

2) No this Pointer: Instance methods implicitly pass a hidden this pointer pointing to the current object. Static methods do not have a this pointer, leaving them with no way to reference instance data.

3) The Ambiguity Problem: If a class has 100 separate objects, each with its own unique name variable, and a static method tries to read name, the compiler has no way to know which of the 100 names you are asking for.

***Static Variable***
=> A shared value across all instances. If one object changes it, every other object sees that change.

***Static Constructor***
=> Runs automatically exactly once—before the first instance is created or any static member is accessed.


## What is Nullable?
=> In C#, Nullable is a feature that allows value types (like int, bool, double, or DateTime) to represent an undefined or missing state by holding a null value.

By default, value types cannot be null. They always contain a default value (like 0 for integers or false for booleans). Nullable types solve this limitation.

it can be done by syntax (int? num = null;)

int? score = null;
int finalScore = score ?? 0; // If score is null, finalScore becomes 0

## What is Linq AND where do we use?
=> LINQ (Language Integrated Query) is a powerful feature in C# that allows you to query, filter, and transform 
data from different sources using a single, unified syntax directly inside your C# code.

Before LINQ, if you wanted to query a SQL database, an XML file, and a standard C# List, you had to learn three entirely 
different technologies. LINQ unifies this so you can query all of them using the exact same C# commands.4

****Where Do We Use LINQ?****
You use LINQ whenever you need to search, sort, filter, or transform data collections. It is categorized by the 
data source it interacts with:

1) LINQ to Objects: Querying in-memory data structures like List<T>, arrays, or dictionaries.

2) LINQ to Entities (Entity Framework): Querying relational databases (SQL Server, PostgreSQL, MySQL) by writing C# 
instead of raw SQL strings.

3) LINQ to XML: Parsing, filtering, and modifying XML files.

4) LINQ to JSON: Querying and filtering JSON data packets (often used with Newtonsoft.Json or System.Text.Json).

***The Two Types of LINQ Syntax

LINQ allows you to write queries in two different styles. Both do the exact same thing behind the scenes, so you can 
choose whichever you find easier to read.

Imagine you have a list of numbers, and you only want the numbers greater than 5, sorted in order.

1. Method Syntax (Most Popular)

Uses extension methods and short lambda expressions (=>). It is compact and widely used in modern C# development.

List<int> numbers = new List<int> { 2, 8, 3, 9, 6 };

var result = numbers.Where(n => n > 5).OrderBy(n => n);
// Output: 6, 8, 9


2. Query Syntax (SQL-Like)

Looks very similar to standard database SQL queries. It is highly readable for developers with database backgrounds.

var result = from n in numbers
             where n > 5
             orderby n
             select n;



## What is FileIO?
=> File I/O (File Input/Output) is the process by which a computer program reads data from, or writes data to, a 
permanent file on a storage drive (like an SSD or HDD).

1) Input (Read): Transferring data from a file on the disk into the computer's memory (RAM) so your program can use it.

2) Output (Write): Transferring data from the computer's memory out to a file on the disk to save it permanently.

Without File I/O, all data in your program disappears the exact moment the application is closed or the computer loses power.

***File I/O in C# (System.IO)***

In C#, all File I/O operations live inside the System.IO namespace. C# provides two main ways to handle files: high-level helper classes for quick tasks, and low-level streams for handling massive files.

1. Quick & Easy Methods (The File Class)

For small to medium files, C# provides a static File class that handles opening, reading/writing, and closing the file automatically in a single line of code.

string path = @"C:\MyFolder\log.txt";

// OUTPUT: Writing text to a file (creates or overwrites it)
File.WriteAllText(path, "Hello World!");

// INPUT: Reading the entire file back into memory
string content = File.ReadAllText(path);
Console.WriteLine(content);


2. Advanced Stream Methods (StreamReader / StreamWriter)

If you try to read a massive 5GB file using File.ReadAllText, your program will instantly crash because it tries to dump all 5GB into RAM at once.

For large files, you use Streams. Streams act like a water pipe, moving data sequentially chunk-by-chunk or line-by-line without overloading your memory.

string path = @"C:\MyFolder\HugeFile.csv";

// Efficiently reading a large file line-by-line
using (StreamReader reader = new StreamReader(path))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line); // Processes one line at a time
    }
} // The 'using' block automatically closes the file stream safely when done



| Task                  | Common C# Method                 |
|-----------------------|----------------------------------|
| Check if file exists  | `File.Exists(path)`              |
| Append text to end    | `File.AppendAllText(path, text)` |
| Delete a file         | `File.Delete(path)`              |
| Copy a file           | `File.Copy(source, destination)` |
| Read raw binary bytes | `File.ReadAllBytes(path)`        |


### What is Singleton Class?
=> A Singleton class is a software design pattern that restricts the instantiation of a class to one single instance across the entire application, while providing a global point of access to that instance.

Once created, that exact same instance is reused everywhere.

***Why Do We Use It?***
=> We use the Singleton pattern when multiple parts of an application need to share a centralized coordinator, and creating multiple instances would cause data conflicts, memory waste, or broken states.

1) Single Source of Truth: Avoids conflicts by ensuring everyone reads from and writes to the exact same memory space (e.g., application configuration settings).

2) Resource Management: Prevents resource exhaustion by reusing a single heavy connection rather than opening hundreds of individual ones (e.g., a database connection pool or print spooler).

3) Global Logging: Coordinates a central file writer so that multiple threads don't attempt to write to the same log file simultaneously, avoiding "File in use" errors.

****How to Implement a Thread-Safe Singleton in C#

To make a class a Singleton, you must block the new keyword by making the constructor private, and provide a static property to access the single instance.

The modern, cleanest way to write this in C# uses the Lazy<T> type to handle thread safety automatically:

public sealed class Logger
{
    // 1. Create a lazy-initialized static instance that handles thread safety
    private static readonly Lazy<Logger> _instance = 
        new Lazy<Logger>(() => new Logger());

    // 2. Make the constructor private so nobody can use 'new Logger()'
    private Logger() 
    {
        // Initialization code (e.g., open a log file)
    }

    // 3. Provide global public access to the single instance
    public static Logger Instance => _instance.Value;

    // Example instance method
    public void LogMessage(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}


```


## Explanation

This C# file demonstrates important programming concepts used in real-world .NET applications.

### Common Concepts
- Classes & Objects
- Methods
- Encapsulation
- Inheritance
- Delegates
- Events
- Collections
- Arrays

---

## Real-World Use Cases

| Concept | Real-World Example |
|---|---|
| Classes | Employee Management |
| Methods | ATM Operations |
| Arrays | Student Marks |
| Collections | Product Lists |
| Events | Button Click |
| Delegates | Callback Systems |

---

## Memory Diagram

```text
Stack Memory
    ↓
Method Calls
    ↓
Heap Memory
    ↓
Objects Stored
```

---


# File: 5b1f1096-481d-4621-a5fc-2074ac17dc15.cs

## Concept Flow

```text
Input
  ↓
Method Execution
  ↓
Logic Processing
  ↓
Output
```

---

## Source Code

```csharp
### Start of Basic OOP Concepts in C#

## Boxing in JAVA & C#
=>  Java Autoboxing Feature
    In Java, primitive types are not objects.
    To treat primitive types as objects, Java have wrapper classes.
    Till Java 1.4 -- Programmer need explicit casting/coding to convert
       primitive type to wrapper types & vice-versa.
    Java 5.0 -- Auto-boxing feature
       implicit conversion from primitive to wrapper and reverse.

    C# Boxing and Unboxing Concept
    C# primitive types are implicitly converted to CTS types.
        e.g. int <--> Int32
    Primitive type variable is also an Object (of Value type).

    IN SIMPLE WORDS CONVERTING PRIMITIVE DATATYPE TO WRAPPER CLASS IN JAVA
    CONVERTING VALUE TYPE TO REFERENCE TYPE IN C#
    IS KNOWN AS A BOXING

    For E.g {
        int num1 = 123;
        object obj = num1;  //BOXING --> Value type to the Reference type
        int num2 = (int)obj; //UNBOXING --> Converting Reference to Value type
    }

## What is PrintInfo?
=> It is a feature in C#,which helps to set the defualt arguments for the given function.

    ```We can call printInfo by Four Type
    1) Using positional Argument
    2) Using named Argument
    3) First Two Arguments are passed positional & next two arguments are passed by name
    4) Using default Argument

   **Syntax:
   {
    void PrintInfo(string name , int age , string address = "AnyWhere" , string email = "Unknown") 
    {
        Console.WriteLine($"name = {name} , age = {age} , addr = {address} , email = {email}");
    }
   }

## What is Method?
=> A method in C# is a self-contained block of code that performs a specific action,   
processes data, or returns a value. If you are coming from languages like C, C++, or Python, 
you might know them as functions; in C#, when a function lives inside a class or struct, 
it is called a method.  

    ```There are three types to call the method.
    1) Call-by Value
    2) Call-by Reference
    3) Using ref Method

## What is Inheritance?
=> Inheritance is an OOP Feature and a Major Pillar in OOP, In it we can inherit the methods/
Functions from the One class to the another class

    We can access the Data Members/Fields from the inherited class 
    
    ```There are the types of an Inheritance as below
    1) Single Inheritance
    2) Multiple Inheritance
    3) Multi-Level Inheritance
    4) Hierarchical Inheritance
    5) Hybrid Inheritance

## What is Upcasting?
=> It is a process of converting Derived Class reference into a Base Class Reference.
   It moves "up" the class hierarchy chain, which is why it is called upcasting.

   ```SYNTAX
   {
    //UPCASTING
       Person p1 = new Employee() { Name = "Kumar", Age = 22, ID = 1, Salary = 1000000.00 };
       p1.DisplayPerson();
   }

     [ Parent Class ]        ▲            Upcasting 
        Person               │     (Always Safe & Automatic)
                             │
     [ Child Class  ]        │
        Employee


## What is DownCasting?
=> It is reverse process of an Upcasting,Which converts Base class reference back into the 
   derived class reference 

   It moves "down" the class hierarchy chain. Because a parent is not always guaranteed to be 
   that specific child, downcasting is not automatic and requires explicit syntax.

     [ Parent Class ]        │
         Person              │  ▼  Downcasting
                             │     (Requires Explicit Syntax & Safety Checks)
     [ Child Class  ]        ▼
        Employee


    ```SYNTAX
    {
        //DOWNCASTING
        Employee e2 = (Employee)p1;
        e2.DisplayEmployee();
    }    

## What is Namespace?WHY/WHEN/WHERE
=> Namespaces are used to Organize the code without namespace all the classes would be mixed up together.
Because in huge companies there would be thousands of classes so using namespace we can avoid the name ambiguity,
name collision,name conflicts using namespaces we can ignore it and keep working with the classes smoothly and with the
help of namespace the projects will be manageable 

****PROPER DEFINITION****
    A namespace is a named container used to organize code and avoid naming conflicts in large applications.


```SYNTAX AND EXAMPLE OF NAMESPACE
{
    using System;

namespace MyApp
{
    class Student
    {
        public void Show()
        {
            Console.WriteLine("Student class");
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();
            s.Show();
        }
    }
}
}


****Real .NET Namespace Flow****

System
 ├── Collections
 │      ├── Generic
 │      └── Concurrent
 │
 ├── IO
 ├── Net
 └── Text



****###Namespace flow is:###****

Project Name
   ↓
Module/Feature Name
   ↓
Classes Related to That Feature
   ↓
Accessed using `using`


## What is Struct?
=> A struct is a user-defined data type used to group related variables together.
It is similar to a class, but with an important difference: It is a Value-Type and Class is a Reference-Type.
When copied → actual data is copied

Instead of Creating Separate Variables everywhere we make an struct/class and group them together and then it is 
created as a custom data type that we use to access the variables while printing or creating the object.

```````````````````````````````````````````````````````
****PROPER DEFINITION*****
A struct is a lightweight value type used to group small related data together efficiently.
```````````````````````````````````````````````````````

````SYNTAX
## CREATING SEPARATE VARIABLES EVERYWHERE:

        string name;
        int roll;
        float marks;

## CREATING THE STRUCT :
        
        struct Student
        {
            public string Name;
            public int Roll;
            public float Marks;
        }
    Now Student becomes your own custom data type.

    ### USED FOR CREATING OBJECT:

    Student s1;
    s1.Name = "Rahul";
    s1.Age = 20;      

AFTERALL it is a value-type so it will not store data on heap>>>Structs are stored mostly in stack memory.
SO,They are :
            >Faster for small objects
            >Lightweight
            >Efficient

******IMPORTANT RULES OF STRUCT******

1. Cannot Inherit Classes
2. Can Implement Interfaces
3. Default Constructor Always Exists
4. Usually Fields are Public
*************************************

```````````````````````````````````````````````````````````
*****Real-Life Analogy*****

Imagine a passport photocopy.

If you give someone a photocopy:

They get their own separate copy
Changes on their copy don't affect yours

That is how struct works.
``````````````````````````````````````````````````````````````````

## What is Data-Type?
=> A data type tells the computer:
   What kind of data is being stored and how much memory should be allocated for it.  

********BASIC REAL-WORLD EXAMPLE*************
    Simple Child-Level Explanation
    Imagine different containers:

        Water Bottle → stores water
        Lunch Box → stores food
        Pencil Box → stores pencils
*********************************************

**********PROPER DEFINITION******************
A data type defines what kind of value a variable can store and how the computer should store and process that data.
*********************************************

```````````````````````````````````````````````````````````````````
MINDMAP DATA-TYPE
DATA TYPES
│
├── 1. VALUE TYPES
│      │
│      ├── A. Integral Types (Whole Numbers)
│      │      │
│      │      ├── sbyte
│      │      ├── byte
│      │      ├── short
│      │      ├── ushort
│      │      ├── int
│      │      ├── uint
│      │      ├── long
│      │      └── ulong
│      │
│      ├── B. Floating Point Types (Decimal Numbers)
│      │      │
│      │      ├── float
│      │      ├── double
│      │      └── decimal
│      │
│      ├── C. Character Type
│      │      │
│      │      └── char
│      │
│      ├── D. Boolean Type
│      │      │
│      │      └── bool
│      │
│      ├── E. Struct Types
│      │      │
│      │      ├── user-defined struct
│      │      ├── DateTime
│      │      ├── TimeSpan
│      │      └── etc.
│      │
│      ├── F. Enum Types
│      │      │
│      │      └── enum
│      │
│      └── G. Nullable Types
│             │
│             ├── int?
│             ├── bool?
│             └── etc.
│
│
├── 2. REFERENCE TYPES
│      │
│      ├── A. Object Type
│      │      │
│      │      └── object
│      │
│      ├── B. String Type
│      │      │
│      │      └── string
│      │
│      ├── C. Class Types
│      │      │
│      │      ├── user-defined classes
│      │      ├── Console
│      │      ├── Random
│      │      └── etc.
│      │
│      ├── D. Interface Types
│      │      │
│      │      └── interface
│      │
│      ├── E. Array Types
│      │      │
│      │      ├── int[]
│      │      ├── string[]
│      │      └── etc.
│      │
│      ├── F. Delegate Types
│      │      │
│      │      └── delegate
│      │
│      └── G. Dynamic Type
│             │
│             └── dynamic
│
│
└── 3. POINTER TYPES (Advanced / Unsafe)
       │
       ├── int*
       ├── char*
       └── etc.
``````````````````````````````````````````````````````````````````

SUMMARY OF DATA TYPE
DATA TYPES
│
├── Numbers → int, float
├── Text → char, string
├── True/False → bool
├── Custom Boxes → class, struct
├── Collections → array
└── Special Smart Types → object, dynamic
```````````````````````````````````````````````````````````````````````
```````````````````````````````````````````````````````````````````````````````````````````````````````
### WHAT IS ENUM?
=> enum (short form of enumeration) is a special data type used to store a fixed set of named constants.
   It helps give meaningful names to numbers.

***************************************************************************
PROPER DEFINITION :
An enum is a special value type used to define a fixed set of named constant values for better readability and safety.
***************************************************************************

   Simple EXAMPLE:

   Imagine traffic lights:

   Red
   Yellow
   Green

   INSTEAD OF WRITING THIS WE CAN WRITE

   1 = Red
   2 = Yellow
   3 = Green

   We can create meaningful names using enum.

````````````````````````````````````````````````````````````````````````````
SYNTAX

enum TrafficSignal
{
    Red,
    Yellow,
    Green
}

HOW ENUM INTERNALLY WORKS:

Red = 0
Yellow = 1
Green = 2

`````````````````````````````````````````````````````````````````````````````
When Do We Use Enum?

Use enum when you have:

✅ Fixed Set of Options

Examples:

Days of week
Months
Traffic signals
Order status
User roles
Game states
``````````````````````````````````````````````````````````````````````````````````````````````````````

```


## Explanation

This C# file demonstrates important programming concepts used in real-world .NET applications.

### Common Concepts
- Classes & Objects
- Methods
- Encapsulation
- Inheritance
- Delegates
- Events
- Collections
- Arrays

---

## Real-World Use Cases

| Concept | Real-World Example |
|---|---|
| Classes | Employee Management |
| Methods | ATM Operations |
| Arrays | Student Marks |
| Collections | Product Lists |
| Events | Button Click |
| Delegates | Callback Systems |

---

## Memory Diagram

```text
Stack Memory
    ↓
Method Calls
    ↓
Heap Memory
    ↓
Objects Stored
```

---

