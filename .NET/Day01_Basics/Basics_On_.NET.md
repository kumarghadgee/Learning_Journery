# Basics and Learning How .NET & C# Work

---

# What is .NET?

.NET is a **software development platform/framework** created by Microsoft that helps developers build applications using languages like:
- C#
- F#
- VB.NET

It provides:
- runtime environment
- libraries
- tools
- memory management
- security
- application support

---

## Simple Understanding

```txt
C#  → Language used to write code
.NET → Platform/framework that runs and supports the code
```

### Real-Life Analogy

```txt
English → Language
Printing Press + Library System → Helps publish and manage books

Similarly,

C# → Language
.NET → Environment/tools/framework that helps run applications
```

---

# History of .NET

- Anders Hejlsberg is the main designer of C#.
- .NET was introduced by Microsoft in 2002.
- Initially it was Windows-focused.
- In 2016, Microsoft introduced .NET Core, making .NET:
  - cross-platform
  - open-source
  - lightweight

Today modern .NET is used for:
- web applications
- cloud services
- desktop applications
- enterprise systems
- mobile applications

---

# Compilation Flow in .NET

```txt
C# Source Code
      ↓
C# Compiler
      ↓
IL Code (Intermediate Language)
      ↓
Assembly (.exe / .dll)
      ↓
CLR Loads Assembly
      ↓
JIT Compiler
      ↓
Native Machine Code
      ↓
Program Executes
```

---

# What is IL (Intermediate Language)?

IL stands for:

```txt
Intermediate Language
```

When we write C# code, it is not directly converted into machine code.

Instead:

```txt
C# Code
   ↓
IL Code
   ↓
CLR + JIT
   ↓
Machine Code
```

IL acts like a common middle language understood by .NET.

---

# What is CLR?

CLR stands for:

```txt
Common Language Runtime
```

CLR is the execution engine of .NET.

It is responsible for:
- memory management
- exception handling
- security
- garbage collection
- loading assemblies
- running applications

---

# What is JIT Compiler?

JIT stands for:

```txt
Just-In-Time Compiler
```

JIT converts:

```txt
IL Code → Native Machine Code
```

This conversion happens during runtime.

---

# What are `.exe` and `.dll` Files?

After compilation, .NET creates:
- `.exe`
- `.dll`

These contain IL code.

Instead of sharing raw source code, applications usually share:

```txt
Compiled Assemblies (.exe / .dll)
```

---

# What is CTS?

CTS stands for:

```txt
Common Type System
```

CTS defines:
- how data types are declared
- how they are stored
- how they are managed in .NET

Example:

```csharp
int
string
bool
```

These C# keywords internally map to CTS types.

---

## Types in CTS

### 1. Value Type
Stores actual data.

Example:

```csharp
int
char
bool
```

---

### 2. Reference Type
Stores memory address/reference.

Example:

```csharp
string
object
array
```

---

# What is CLS?

CLS stands for:

```txt
Common Language Specification
```

CLS is a subset of CTS.

It defines common rules that all .NET languages should follow so different languages can work together.

---

## Purpose of CLS

- language interoperability
- reusable libraries
- compatibility between .NET languages

---

# Basic Syntax Structure

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
}
```

---

# Important Terms

## Namespace

A namespace is used to organize related classes and avoid naming conflicts.

Similar to:

```txt
Java Package
```

---

## Console

`Console` is a built-in class provided by .NET libraries for console input/output.

---

## WriteLine()

`WriteLine()` is a method of the `Console` class used to print output.

Example:

```csharp
Console.WriteLine("Hello");
```

---

# C# / .NET vs Java Comparison

| C# / .NET | Java Equivalent | Meaning |
|---|---|---|
| .NET | Java Platform | Development platform |
| C# | Java | Programming language |
| CLR | JVM | Runtime environment |
| IL | Bytecode | Intermediate code |
| JIT Compiler | JIT Compiler | Converts intermediate code |
| CTS | Java Type System | Data type system |
| Namespace | Package | Organizes classes |
| Assembly (.dll/.exe) | JAR | Compiled reusable unit |
| Garbage Collector | Garbage Collector | Cleans unused memory |

---

# What is DLL?

DLL stands for:

```txt
Dynamic Link Library
```

A DLL is a reusable compiled file that contains:
- classes
- methods
- functions
- libraries
- resources

Multiple applications can use the same DLL.

---

# Why DLL is Used?

Instead of rewriting common code repeatedly:

```txt
Common Code
    ↓
Compile
    ↓
DLL Created
    ↓
Used by Multiple Applications
```

This improves:
- code reusability
- modularity
- maintainability
- development speed

---

# Real-Life Analogy for DLL

```txt
Hospital Example:

Instead of every doctor creating their own X-ray machine,
the hospital creates one shared X-ray department.

All doctors use it.

Similarly:
one DLL
many applications use it.
```

---

# Runtime Flow of DLL

```txt
Application Starts
      ↓
CLR Loads Required DLLs
      ↓
JIT Compiles Required Methods
      ↓
Execution Happens
```

---

# Quick Revision Notes

## .NET
Software development platform/framework.

## C#
Programming language used with .NET.

## CLR
Runs .NET applications.

## IL
Intermediate code generated after compilation.

## JIT
Converts IL to machine code.

## CTS
Defines data types in .NET.

## CLS
Common rules for .NET language compatibility.

## DLL
Reusable compiled library.

## Namespace
Organizes code and avoids naming conflicts.

