# C# Notes & OOP Concepts 🚀
## Complete Beginner-Friendly Notes for C# / .NET

---

# Table of Contents

1. Boxing & Unboxing
2. Methods in C#
3. Optional Parameters / PrintInfo
4. Inheritance
5. Upcasting & Downcasting
6. Namespace
7. Struct
8. Data Types
9. Enum
10. Quick Revision Summary

---

# 1. Boxing & Unboxing

## What is Boxing?

Boxing is the process of converting a **Value Type** into a **Reference Type**.

```csharp
int num = 100;
object obj = num;   // Boxing
```

Here:
- `int` is a value type
- `object` is a reference type

The value gets wrapped inside an object.

---

## What is Unboxing?

Unboxing is converting a **Reference Type** back into a **Value Type**.

```csharp
int num2 = (int)obj;   // Unboxing
```

---

# Internal Flow

```text
VALUE TYPE
   ↓
BOXING
   ↓
REFERENCE TYPE (object)
   ↓
UNBOXING
   ↓
VALUE TYPE
```

---

# Real-World Use Cases

## Collections
Earlier non-generic collections stored everything as objects.

```csharp
ArrayList list = new ArrayList();
list.Add(10);   // Boxing
```

---

# Memory Concept

```text
Stack Memory                Heap Memory
------------               ------------
int num = 10       →       object obj
```

---

# Important Points

| Boxing | Unboxing |
|---|---|
| Value → Reference | Reference → Value |
| Automatic | Explicit casting required |
| Slightly slower | Faster after cast |

---

# 2. Methods in C#

## What is a Method?

A method is a reusable block of code that performs a specific task.

```csharp
void Show()
{
    Console.WriteLine("Hello World");
}
```

---

# Why Methods?

- Reusability
- Clean code
- Reduce repetition
- Easier debugging

---

# Real-World Example

## ATM Machine

```text
WithdrawMoney()
DepositMoney()
CheckBalance()
```

Each operation is a method.

---

# Method Calling Types

## 1. Call By Value

Copy of variable passed.

```csharp
void Change(int x)
{
    x = 100;
}
```

Original value does not change.

---

## 2. Call By Reference

Original variable passed.

```csharp
void Change(ref int x)
{
    x = 100;
}
```

Original value changes.

---

# Method Flow

```text
Method Called
      ↓
Code Executes
      ↓
Returns Result
```

---

# 3. Optional Parameters / PrintInfo

Optional parameters allow default values.

```csharp
void PrintInfo(string name, int age, string city = "Pune")
{
    Console.WriteLine(name);
}
```

---

# Ways to Pass Arguments

## 1. Positional Arguments

```csharp
PrintInfo("Rahul", 22);
```

---

## 2. Named Arguments

```csharp
PrintInfo(age:22, name:"Rahul");
```

---

## 3. Default Arguments

```csharp
PrintInfo("Rahul", 22);
```

City automatically becomes `Pune`.

---

# Real-World Use Case

Used heavily in:
- APIs
- Optional filters
- Configuration methods
- Utility functions

---

# 4. Inheritance

## What is Inheritance?

Inheritance allows one class to reuse another class properties and methods.

```csharp
class Person
{
    public string Name;
}

class Employee : Person
{
    public int Salary;
}
```

---

# Inheritance Diagram

```text
        Person
           ↑
           │
        Employee
```

Employee inherits features of Person.

---

# Why Use Inheritance?

- Code Reusability
- Reduces duplication
- Creates hierarchy
- Easier maintenance

---

# Types of Inheritance

| Type | Meaning |
|---|---|
| Single | One parent → One child |
| Multilevel | Grandparent → Parent → Child |
| Hierarchical | One parent → Multiple children |
| Hybrid | Combination |
| Multiple | Via interfaces in C# |

---

# Real-World Example

```text
Vehicle
 ├── Car
 ├── Bike
 └── Bus
```

---

# 5. Upcasting & Downcasting

# Upcasting

Converting Child reference into Parent reference.

```csharp
Person p = new Employee();
```

---

# Upcasting Diagram

```text
Employee  →  Person
  Child       Parent
```

✅ Safe & Automatic

---

# Downcasting

Converting Parent reference back into Child reference.

```csharp
Employee e = (Employee)p;
```

---

# Downcasting Diagram

```text
Person  →  Employee
Parent      Child
```

⚠ Requires explicit casting.

---

# Real-World Use Case

Used heavily in:
- Polymorphism
- Frameworks
- Collections
- Runtime object handling

---

# 6. Namespace

## What is Namespace?

Namespace organizes code and avoids naming conflicts.

```csharp
namespace MyApp
{
    class Student
    {
    }
}
```

---

# Why Namespace?

- Organize code
- Avoid name conflicts
- Manage large applications
- Group related classes

---

# Namespace Flow

```text
Project
   ↓
Module
   ↓
Classes
```

---

# Real .NET Namespace Flow

```text
System
 ├── Collections
 ├── IO
 ├── Net
 └── Text
```

---

# Real-World Example

```text
BankingApp
 ├── Models
 ├── Services
 ├── Controllers
 └── Utilities
```

---

# Using Namespace

```csharp
using System;
```

This allows direct use of classes inside System namespace.

---

# 7. Struct

## What is Struct?

Struct is a lightweight value type used to group related data.

```csharp
struct Student
{
    public string Name;
    public int Roll;
}
```

---

# Struct Memory Concept

```text
Struct = Value Type
Stored Mostly in Stack
```

---

# Struct vs Class

| Struct | Class |
|---|---|
| Value Type | Reference Type |
| Stack | Heap |
| Faster | Flexible |
| Lightweight | Powerful |

---

# Important Rules

- Cannot inherit classes
- Can implement interfaces
- Default constructor exists
- Best for small objects

---

# Real-World Use Cases

Used in:
- Game development
- Graphics programming
- Coordinates
- Date & Time
- Mathematical calculations

---

# Struct Flow

```text
Small Related Data
        ↓
Group Together
        ↓
Create Struct
        ↓
Use as Custom Data Type
```

---

# 8. Data Types

## What is Data Type?

Data type defines:
- What kind of value can be stored
- How memory is allocated

---

# Basic Syntax

```csharp
int age = 22;
string name = "Rahul";
bool isPassed = true;
```

---

# Data Type Categories

# VALUE TYPES

```text
int
float
double
bool
char
struct
enum
```

---

# REFERENCE TYPES

```text
string
class
array
object
interface
delegate
```

---

# POINTER TYPES

```text
int*
char*
```

---

# Data Type Mind Map

```text
Data Types
│
├── Value Types
│     ├── int
│     ├── float
│     ├── bool
│     ├── char
│     ├── struct
│     └── enum
│
├── Reference Types
│     ├── string
│     ├── class
│     ├── array
│     └── object
│
└── Pointer Types
```

---

# Real-World Analogy

```text
Water Bottle → water
Lunch Box → food
Pencil Box → pencils
```

Different containers store different things.

---

# Real-World Use Cases

| Data | Type |
|---|---|
| Age | int |
| Name | string |
| Price | decimal |
| Status | bool |

---

# 9. Enum

## What is Enum?

Enum is used to store fixed set of named constants.

```csharp
enum TrafficSignal
{
    Red,
    Yellow,
    Green
}
```

---

# Internal Working

```text
Red = 0
Yellow = 1
Green = 2
```

---

# Why Enum?

- Better readability
- Avoid magic numbers
- Cleaner code
- Fixed valid choices

---

# Real-World Use Cases

Used in:
- Order Status
- User Roles
- Game States
- Traffic Signals
- Days of Week

---

# Enum Example

```csharp
enum OrderStatus
{
    Pending,
    Shipped,
    Delivered
}
```

---

# Enum Flow

```text
Fixed Choices
      ↓
Meaningful Names
      ↓
Cleaner & Safer Code
```

---

# 10. Quick Revision Summary

| Concept | Main Purpose |
|---|---|
| Boxing | Value → Reference |
| Unboxing | Reference → Value |
| Method | Reusable code block |
| Inheritance | Reuse features |
| Upcasting | Child → Parent |
| Downcasting | Parent → Child |
| Namespace | Organize code |
| Struct | Lightweight data holder |
| Data Type | Defines storage type |
| Enum | Fixed named constants |

---

# One-Line Memory Tricks 🧠

```text
Namespace → Organize code
Struct → Lightweight object
Enum → Fixed choices
Datatype → Defines storage
Inheritance → Reuse code
Method → Perform task
```

---

---

# 11. Object Slicing

## What is Object Slicing?

Object slicing happens when a derived class object is assigned to a base class object/reference and only the base class part remains accessible.

```csharp
class Base
{
    public int baseData;
}

class Derived : Base
{
    public int derivedData;
}

Derived d = new Derived();
Base b = d;
```

---

# Object Slicing Flow

```text
Derived Object
│
├── Base Data
└── Derived Data

Assigned to Base
        ↓
Only Base Portion Accessible
```

---

# Real-World Understanding

Imagine a smartphone:

```text
SmartPhone
├── Calling
├── Camera
└── Internet
```

If treated as simple phone:

```text
Only Calling Feature Accessible
```

---

# 12. Virtual Function & Override

## What is Virtual Function?

A virtual function allows child classes to change parent class behavior.

```csharp
class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Show");
    }
}
```

---

# What is Override?

Override replaces parent implementation in child class.

```csharp
class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child Show");
    }
}
```

---

# Runtime Polymorphism Flow

```text
Parent Ref → Child Object
        ↓
Runtime decides actual method
```

---

# Real-World Use Case

Used in:
- Payment gateways
- Notification systems
- Game engines
- Plugin systems

---

# 13. Method Hiding / new Keyword

## What is Method Hiding?

When child class creates its own method using `new` keyword.

```csharp
public new void Display()
{
    Console.WriteLine("Child Display");
}
```

---

# Difference Between Override & New

| Override | new |
|---|---|
| Replaces parent method | Hides parent method |
| Runtime polymorphism | Compile-time behavior |
| Requires virtual | No virtual needed |

---

# 14. Polymorphism

## What is Polymorphism?

Polymorphism means:

```text
One Name → Multiple Forms
```

---

# Types of Polymorphism

```text
Polymorphism
│
├── Compile-Time
│      ├── Method Overloading
│      └── Operator Overloading
│
└── Runtime
       └── Method Overriding
```

---

# Real-World Example

```csharp
Person p = new Student();
p.Display();
```

Same method behaves differently.

---

# 15. Abstract Class & Abstract Method

## Abstract Class

Cannot create objects directly.

```csharp
abstract class Animal
{
}
```

---

# Abstract Method

Method without implementation.

```csharp
abstract class Animal
{
    public abstract void Sound();
}
```

---

# Flow

```text
Abstract Class
      ↓
Blueprint
      ↓
Child Classes Must Implement
```

---

# Real-World Example

```text
Vehicle
 ├── Start()
 ├── Stop()
 └── Child defines Engine Logic
```

---

# 16. Sealed

## What is Sealed?

Sealed prevents further inheritance or overriding.

---

# Sealed Method

```csharp
public sealed override void Show()
{
}
```

---

# Sealed Class

```csharp
sealed class Clerk
{
}
```

---

# Real-World Use Case

Used when:
- Security required
- Final implementation needed
- Prevent accidental modification

---

# 17. Array of References

## What is Array of References?

Stores memory addresses of objects instead of actual objects.

```csharp
Emp[] emps = new Emp[5];
```

---

# Internal Flow

```text
Array Slot
    ↓
Stores Object Address
    ↓
Points to Heap Object
```

---

# Visual Diagram

```text
emps[0] ───► Manager Object
emps[1] ───► Employee Object
emps[2] ───► null
```

---

# Real-World Use Cases

Used in:
- Employee systems
- Collections
- Polymorphic storage
- Framework internals

---

# 18. Interface

## What is Interface?

Interface is a contract.

It defines WHAT to do, not HOW to do.

```csharp
interface IPrinter
{
    void Print();
}
```

---

# Implementing Interface

```csharp
class HPPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }
}
```

---

# Interface Flow

```text
Interface
    ↓
Defines Rules
    ↓
Classes Implement Rules
```

---

# Why Interfaces?

- Loose Coupling
- Flexibility
- Multiple inheritance support
- Easier testing

---

# Real-World Example

```text
Payment Interface
 ├── PhonePe
 ├── GPay
 └── Paytm
```

---

# 19. Dependency Injection (DI)

## What is DI?

Dependencies are provided from outside instead of creating internally.

---

# Without DI

```text
Class creates object itself
```

Tight coupling.

---

# With DI

```text
Dependency passed from outside
```

Loose coupling.

---

# Types of DI

| Type | Meaning |
|---|---|
| Constructor Injection | Through constructor |
| Property Injection | Through property |
| Method Injection | Through method |

---

# Real-World Example

```text
Food Delivery App
│
├── Payment Service
├── Notification Service
└── Database Service
```

Services injected externally.

---

# 20. Generics

## What are Generics?

Generics allow same code to work with different data types.

```csharp
List<int>
List<string>
```

---

# Generic Method Example

```csharp
void Show<T>(T data)
{
    Console.WriteLine(data);
}
```

---

# Why Generics?

- Type Safety
- Better Performance
- Reusable code
- Avoid boxing/unboxing

---

# Real-World Use Cases

Used in:
- Collections
- APIs
- Libraries
- Frameworks

---

# 21. Delegate

## What is Delegate?

Delegate is an object-oriented function pointer.

```csharp
delegate void MyDelegate();
```

---

# Delegate Flow

```text
Delegate
   ↓
Stores Method Reference
   ↓
Invokes Method
```

---

# Real-World Use Cases

- Event handling
- Callbacks
- Lambda expressions
- Async programming

---

# 22. Multicast Delegate

## What is Multicast Delegate?

Stores multiple methods.

```csharp
ptr += Add;
ptr += Subtract;
```

---

# Execution Flow

```text
Delegate Triggered
      ↓
Runs Method 1
      ↓
Runs Method 2
      ↓
Runs Method 3
```

---

# Invocation List Chaining

```text
ptr
├── Method1
├── Method2
├── Method3
└── Lambda
```

---

# 23. IComparable vs IComparer

# IComparable

Default internal sorting.

```csharp
class Employee : IComparable<Employee>
{
    public int CompareTo(Employee other)
    {
        return this.Id.CompareTo(other.Id);
    }
}
```

---

# IComparer

External custom sorting.

```csharp
class SortByName : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
```

---

# Flow Comparison

```text
IComparable
   ↓
Default Sorting

IComparer
   ↓
Custom Sorting
```

---

# Real-World Example

```text
Employee Sorting
├── By ID
├── By Name
└── By Salary
```

---

# Final Quick Revision Table

| Concept | Purpose |
|---|---|
| Virtual | Allow overriding |
| Override | Change parent behavior |
| Interface | Contract |
| DI | Loose coupling |
| Delegate | Store method reference |
| Generic | Reusable type-safe code |
| Abstract | Blueprint class |
| Sealed | Final implementation |
| IComparable | Default sorting |
| IComparer | Custom sorting |

---

# Tags


`#csharp` `#dotnet` `#oop` `#backend` `#programming` `#codingnotes`

