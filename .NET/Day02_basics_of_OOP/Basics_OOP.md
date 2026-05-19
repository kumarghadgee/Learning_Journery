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

| Concept     | Main Purpose            |
|-------------|-------------------------|   
| Boxing      | Value → Reference       |
| Unboxing    | Reference → Value       |
| Method      | Reusable code block     |
| Inheritance | Reuse features          |
| Upcasting   | Child → Parent          |
| Downcasting | Parent → Child          |
| Namespace   | Organize code           |
| Struct      | Lightweight data holder |
| Data Type   | Defines storage type    |
| Enum        | Fixed named constants   |

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

# Tags

`#csharp` `#dotnet` `#oop` `#backend` `#programming` `#codingnotes`

