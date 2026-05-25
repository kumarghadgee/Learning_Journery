# C# & .NET Complete Quick Revision Notes 🚀

## Beginner to Intermediate C# Revision Guide

---

# Topics Covered

- OOP Concepts
- Struct vs Class
- Enum
- Delegates & Events
- Collections
- Exception Handling
- Serialization
- Reflection
- Dynamic
- Facade Pattern
- Expression Trees
- Performance in C#

---

# 1. OOP Concepts

## What is OOP?

Object-Oriented Programming organizes code using:
- Classes
- Objects
- Inheritance
- Polymorphism
- Encapsulation
- Abstraction

---

# OOP Flow

```text
Class
   ↓
Object
   ↓
Methods & Properties
   ↓
Program Logic
```

---

# Real-World Example

```text
Car
├── Color
├── Speed
└── Start()
```

---

# 2. Struct vs Class

| Struct | Class |
|---|---|
| Value Type | Reference Type |
| Stack Memory | Heap Memory |
| Faster | Flexible |
| Lightweight | Feature-rich |

---

# Struct Example

```csharp
struct Student
{
    public int Roll;
    public string Name;
}
```

---

# 3. Enum

```csharp
enum Status
{
    Pending,
    Shipped,
    Delivered
}
```

---

# Enum Flow

```text
Fixed Values
    ↓
Meaningful Names
    ↓
Readable Code
```

---

# 4. Delegates & Events

## Delegate

```csharp
delegate void MyDelegate();
```

## Event

```csharp
public event EventHandler Click;
```

---

# Event Flow

```text
Event Occurs
      ↓
Publisher Raises Event
      ↓
Subscribers Execute
```

---

# 5. Collections

| Collection | Purpose |
|---|---|
| List<T> | Dynamic array |
| Dictionary | Key-value pairs |
| Queue | FIFO |
| Stack | LIFO |

---

# Collection Flow

```text
Add Data
   ↓
Store Data
   ↓
Search / Remove / Update
```

---

# 6. Exception Handling

## Exception Flow

```text
Code Executes
    ↓
Error Occurs
    ↓
catch Handles Error
    ↓
finally Cleanup
```

---

# Syntax

```csharp
try
{
}
catch(Exception ex)
{
}
finally
{
}
```

---

# 7. Serialization

## Serialization Flow

```text
Object
   ↓
Serialization
   ↓
JSON/XML/Binary
   ↓
Storage or Transfer
```

---

# Serialization Types

| Type | Usage |
|---|---|
| JSON | APIs |
| XML | Legacy systems |
| Binary | High performance |

---

# 8. Reflection

## Reflection Flow

```text
Assembly
   ↓
Metadata
   ↓
Dynamic Inspection
```

---

# Syntax

```csharp
Type t = typeof(string);
Console.WriteLine(t.Name);
```

---

# 9. Dynamic Keyword

```csharp
dynamic value = "Hello";
```

---

# Flow

```text
Compile
   ↓
Runtime Type Resolution
```

---

# 10. Facade Pattern

## Facade Flow

```text
Client
   ↓
Facade
   ↓
Subsystems
```

---

# Real-World Example

```text
OrderFacade
 ├── Payment
 ├── Inventory
 └── Shipping
```

---

# 11. Expression Trees

## Expression Tree Diagram

```text
      [ + ]
     /     \
  [ 5 ]   [ * ]
          /   \
       [ 3 ] [ 2 ]
```

---

# Use Cases

- LINQ
- Entity Framework
- Query generation

---

# 12. Performance in C#

# JIT vs AOT

| JIT | AOT |
|---|---|
| Runtime compile | Precompiled |
| Slower startup | Faster startup |

---

# Performance Killers

| Problem | Impact |
|---|---|
| Boxing | Heap allocation |
| Reflection | Slow runtime |
| String Concatenation | Multiple allocations |

---

# Memory Diagram

```text
Stack → Fast
Heap  → Managed by GC
```

---

# Complete Quick Revision Table 🧠

| Concept | Quick Meaning |
|---|---|
| Class | Blueprint |
| Object | Real instance |
| Struct | Lightweight type |
| Enum | Fixed values |
| Delegate | Function pointer |
| Event | Notification system |
| Collection | Dynamic storage |
| Exception | Runtime error |
| Reflection | Runtime inspection |
| Serialization | Convert object to data |
| Dynamic | Runtime typing |
| Facade | Simplified interface |
| Expression Tree | Code as data |

---

# Final Mind Map

```text
C# & .NET
│
├── OOP
├── Collections
├── Runtime Features
├── Reflection
├── Design Patterns
└── Performance
```

---

# Original Uploaded Notes

```md
### C#-OOP & .NET A quick revision session

## What is FACADE Pattern?
=> The Facade Pattern is a structural design pattern that provides a simplified interface to a complex system of classes, libraries, or frameworks. In C#, it is typically implemented as a wrapper class that provides high-level methods to orchestrate various subsystem operations behind the scenes.4

***Key Concepts***

1) Simplified Interface: It offers a single "front desk" entry point for clients, hiding the "paperwork" of complex internal components.

2) Decoupling: The client code only interacts with the Facade, reducing dependencies on the actual subsystem implementation.

3) Layering: It helps in organizing code into layers, where a higher-level layer uses a Facade to communicate with lower-level subsystems.

***When to Use It***

- When you want to provide a simple interface to a complex subsystem.

- When there are many dependencies between clients and the implementation classes of an abstraction.

- When you need to wrap a poorly designed API that you cannot change, making it more readable and maintainable.

***Real-World Example***

Think of an Order Management System in an e-commerce app. To place an order, the system must check inventory, process payment, and notify shipping. Instead of the client managing all these services, a RestaurantFacade (as shown in C# Corner) or a MortgageFacade (on Dofactory.com) handles the orchestration internally

***Basic C# Structure***

1) Subsystem Classes: The complex classes that perform actual work.

2) Facade Class: The wrapper that knows which subsystem class is responsible for a request and delegates work accordingly.

3) Client: The user of the Facade who no longer needs to worry about the underlying complexity.

## what is expression tree in c#?
=> An Expression Tree in C# is a data structure that represents code in a tree-like format, where each node is an object (an expression) instead of executable instructions.

Unlike standard compiled code, expression trees allow you to treat code as data that you can inspect, modify, parse, or translate at runtime.

***Why Do We Need Expression Trees?***

1) Code Translation: They translate C# code into other formats like SQL. This is how Entity Framework (EF) converts LINQ queries (db.Users.Where(u => u.Id == 5)) into native database queries.

2) Dynamic Code Execution: They let you build logic dynamically at runtime and compile it on the fly, which is often faster than using standard Reflection.

***The Code-as-Data Visual Analogy***

Consider the mathematical expression: 5 + (3 * 2)

In standard code, the CPU just computes 11. In an Expression Tree, the compiler breaks it down into a hierarchical structure:

       [ + ] (BinaryExpression)
      /     \
   [ 5 ]   [ * ] (BinaryExpression)
           /   \
        [ 3 ] [ 2 ]


## what is  performance of the execution of an program in c#?
=> The performance of a C# program depends on how efficiently it uses hardware resources like the CPU, memory, and disk. Because C# runs on the .NET runtime, performance is determined by a mix of your code structure, compilation types, and runtime management.

Here is a breakdown of how C# execution performance works under the hood.

1. Compilation Styles: JIT vs. AOT
-> 1. Compilation Styles: JIT vs. AOT
C# code does not compile directly into machine language. It compiles into Intermediate Language (IL). How that IL turns into machine code radically changes performance:

JIT (Just-In-Time) Compilation: This is the default. The runtime compiles IL to machine code while the app is running, right before a method executes.

Pro: Optimizes code specifically for the user’s exact CPU architecture.

Con: Causes a "cold start" delay when the app first launches or when a method runs for the first time.

Native AOT (Ahead-Of-Time): Introduced heavily in modern .NET, this compiles C# directly into native machine code before deployment.

Pro: Instant startup times and significantly lower memory footprints.

Con: No runtime JIT optimizations, and certain dynamic reflection features are restricted.


2. Memory Management and the Garbage Collector (GC)
-> C# uses automatic memory management. While this prevents memory leaks, it introduces a performance trade-off called Garbage Collection overhead:

Managed Heap: Objects (classes) are allocated here. The GC periodically pauses threads to scan for and clean up unused memory.

GC Pauses: If your code creates millions of short-lived objects, the GC has to work harder. This causes microscopic freezes (latencies) in your program.

Value Types vs. Reference Types: Storing data on the Stack (struct, int, bool) is practically free and instant. Storing data on the Heap (class, string) requires allocation tracking and GC cleanup.

3. Key Performance Killers in C#

Common architectural patterns can severely slow down execution speeds:

Boxing and Unboxing: Converting a value type to a reference type (e.g., forcing an int into an object). This creates unexpected heap allocations.

Reflection: Inspecting code metadata at runtime is highly flexible but incredibly slow.

String Concatenation: Strings in C# are immutable. Doing str += "next" in a loop creates a brand-new string object on every single iteration.

4. Modern C# Performance Features
-> Modern .NET versions (like .NET 8 and .NET 9) are engineered for hyper-performance, giving C# speeds that rival C++ in web and backend contexts:

Span<T> and ReadOnlySpan<T>: Allows you to work with contiguous chunks of memory safely without allocating new heap memory. Essential for high-speed text parsing.

Hardware Intrinsics: Allows C# code to call specific CPU instructions (like SIMD for parallel processing data arrays) directly.

SIMD (Single Instruction, Multiple Data): Vectorized operations that perform math on multiple pieces of data in a single CPU cycle.
```

---

# Tags

`#csharp` `#dotnet` `#oop` `#reflection` `#performance`
