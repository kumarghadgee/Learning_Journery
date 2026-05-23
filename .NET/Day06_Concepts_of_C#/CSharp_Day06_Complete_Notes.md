# C# Day 06 Complete Notes 🚀
## Serialization, Exceptions, Indexers, Enumerators, Dynamic & Reflection

---

# 1. Serialization

## What is Serialization?

Serialization converts an object into a transferable format such as:
- JSON
- XML
- Binary

Deserialization recreates the object again.

---

# Serialization Flow

```text
Object
   ↓
Serialization
   ↓
JSON / XML / Binary
   ↓
Store or Send
   ↓
Deserialization
   ↓
Original Object
```

---

# Types of Serialization

| Type | Description | Best Use |
|---|---|---|
| JSON | Lightweight readable format | Web APIs |
| XML | Structured format | Legacy systems |
| Binary | Compact byte stream | Performance systems |

---

# Real-World Use Cases

- Web APIs
- Game saves
- Distributed systems
- Database storage

---

# 2. Exception Handling

## What is Exception?

An exception is an unexpected runtime error.

---

# Common Exceptions

| Exception | Meaning |
|---|---|
| NullReferenceException | Object is null |
| DivideByZeroException | Division by zero |
| FileNotFoundException | Missing file |
| IndexOutOfRangeException | Invalid array index |

---

# Exception Flow

```text
Code Executes
     ↓
Error Occurs
     ↓
catch Handles Error
     ↓
finally Executes Cleanup
```

---

# Syntax

```csharp
try
{
    int divisor = 0;
    int result = 10 / divisor;
}
catch(DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Cleanup");
}
```

---

# Real-World Example

```text
ATM System
    ↓
Insufficient Balance
    ↓
Exception Raised
    ↓
Handled Gracefully
```

---

# 3. Indexers

## What is Indexer?

An indexer allows an object to behave like an array using [].

---

# Syntax

```csharp
public string this[int index]
{
    get { return _array[index]; }
    set { _array[index] = value; }
}
```

---

# Flow

```text
Object
   ↓
Indexer []
   ↓
get / set
   ↓
Internal Data Access
```

---

# Real-World Use Cases

- Custom collections
- Matrix systems
- Wrappers
- Data grids

---

# 4. Enumerators

## What is Enumerator?

Enumerator iterates through collection items one by one.

---

# foreach Internal Working

```csharp
foreach(var item in myList)
{
    Console.WriteLine(item);
}
```

Internally:

```csharp
var enumerator = myList.GetEnumerator();

while(enumerator.MoveNext())
{
    var item = enumerator.Current;
}
```

---

# Core Components

| Method | Purpose |
|---|---|
| MoveNext() | Move next |
| Current | Current item |
| Reset() | Reset enumerator |

---

# Enumerator Flow

```text
Collection
    ↓
GetEnumerator()
    ↓
MoveNext()
    ↓
Current
```

---

# 5. Dynamic Keyword

## What is dynamic?

dynamic skips compile-time type checking.

Type checking happens at runtime.

---

# Syntax

```csharp
dynamic value = "Hello";
Console.WriteLine(value.Length);

value = 123;
```

---

# Flow

```text
Compiler Skips Checking
          ↓
Program Runs
          ↓
Runtime Resolves Type
```

---

# dynamic vs var vs object

| Feature | dynamic | var | object |
|---|---|---|---|
| Type Resolution | Runtime | Compile-time | Compile-time |
| Performance | Slower | Fast | Fast |
| Casting Needed | No | No | Yes |

---

# Real-World Use Cases

- Reflection systems
- JSON parsing
- COM interoperability
- Dynamic scripting

---

# 6. Reflection

## What is Reflection?

Reflection allows program inspection at runtime.

It can:
- Inspect classes
- Read metadata
- Invoke methods dynamically

---

# Reflection Flow

```text
Assembly
   ↓
Metadata
   ↓
Inspect Types
   ↓
Invoke Dynamically
```

---

# Syntax

```csharp
Type t = typeof(string);

Console.WriteLine(t.Name);
```

---

# Real-World Use Cases

| Use Case | Example |
|---|---|
| Dependency Injection | ASP.NET Core DI |
| Unit Testing | xUnit |
| Serialization | JSON serializers |
| Object Mapping | AutoMapper |

---

# Quick Revision Summary

| Concept | Purpose |
|---|---|
| Serialization | Convert object to data |
| Exception | Handle runtime errors |
| Indexer | Access object like array |
| Enumerator | Iterate collection |
| dynamic | Runtime type handling |
| Reflection | Inspect metadata |

---

# One-Line Memory Tricks 🧠

```text
Serialization → Convert object to transferable data
Exception → Handle runtime errors
Indexer → Object behaves like array
Enumerator → Move through collection
dynamic → Runtime type checking
Reflection → Program inspects itself
```

---

# Original Uploaded C# Content

```csharp
### Day:06 Concepts of C# 

## What is Serialization?
=> Serialization is the process of converting an object or a graph of objects into a linear sequence of bytes for either storage or transmission to another location. Deserialization is the process of taking in stored information and recreating objects from it.

The ISerializable interface provides a way for classes to control their own serialization behavior. Classes in the System.Runtime.Serialization.Formatters namespace control the actual formatting of various data types encapsulated in the serialized objects.

Formatters that serialize and deserialize objects to and from a particular format can be found in the System.Runtime.Serialization.Formatters namespace.

***Types of Serialization in C#***

Depending on your needs, you can choose from several formats:


| Serialization Type | Description                                                       | Best For...                                                                                            |
|--------------------|-------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| **JSON**           | Converts objects to a lightweight, human-readable string. | Web APIs, cross-platform apps.                                                                                 |
| **XML**            | Converts public properties and fields into XML format. | Compatibility with legacy systems or SOAP services.                                                               |
| **Binary**         | Creates a compact byte stream that preserves exact type fidelity. | High performance; note that [Microsoft now considers BinaryFormatter outdated](https://microsoft.com). |


### What is Exception in C#?
=> An exception in C# is an unexpected event or error that occurs during the execution of a program. It disrupts the normal flow of instructions and causes the program to crash if it is not properly handled.

Exceptions are objects that derive from the System.Exception base class.

***Common Examples of Exceptions***

1) NullReferenceException: Trying to use an object that is null.

2) DivideByZeroException: Attempting to divide a number by zero.

3) FileNotFoundException: Trying to open a file that does not exist.

4) IndexOutOfRangeException: Accessing an array element with an invalid index.

***How to Handle Exceptions (Try-Catch)***

C# uses four keywords to handle exceptions: try, catch, finally, and throw.


try
{
    // Code that might cause an error
    int divisor = 0;
    int result = 10 / divisor; 
}
catch (DivideByZeroException ex)
{
    // Code to handle this specific error
    Console.WriteLine($"Error occurred: {ex.Message}");
}
finally
{
    // Code that ALWAYS runs, used for cleanup (e.g., closing files)
    Console.WriteLine("Cleanup code goes here.");
}

Why Use Exception Handling?

1) Prevents Crashes: Keeps your application running even when something goes wrong.

2) Separates Error Code: Keeps business logic clean by separating it from error recovery.

3) Provides Details: Exception objects capture call stacks and error messages to help you debug.


### What is Indexer?
=> An indexer in C# allows an object to be indexed like an array. It lets you use the bracket syntax [] directly on 
an instance of a class or struct.

Instead of writing a custom method like instance.GetItem(index), you can simply write instance[index].

***Key Characteristics***

1) Property-like: Indexers are defined like properties but use the this keyword and take parameters.

2) Custom Logic: You can write custom code inside their get and set accessors to validate data.

3) Flexible Types: The index parameter does not have to be an integer; it can be a string, a Guid, or any other type.

***How to Implement It***

Here is a basic example of an indexer used to wrap an internal array:

public class StringCollection
{
    private string[] _array = new string[10];

    // Defining the indexer
    public string this[int index]
    {
        get { return _array[index]; }
        set { _array[index] = value; }
    }
}

// How to use it:
var collection = new StringCollection();
collection[0] = "Hello"; // Calls the 'set' accessor
string word = collection[0]; // Calls the 'get' accessor


### What is Enumerator?
=> An enumerator in C# is an object that acts like a cursor to step through a collection one item at a time. It provides 
a read-only, forward-only way to loop through data without exposing the underlying structure of the collection.

In the .NET ecosystem, any class that implements the IEnumerator (or IEnumerator<T>) interface is considered an enumerator.

***The Connection to foreach***
You rarely use an enumerator directly. Instead, whenever you write a foreach loop, C# automatically converts it into 
enumerator code behind the scenes.

foreach (var item in myList)
{
    Console.WriteLine(item);
}

var enumerator = myList.GetEnumerator();
while (enumerator.MoveNext())
{
    var item = enumerator.Current;
    Console.WriteLine(item);
}

***Core Components***

An enumerator relies on three primary members:

1) MoveNext(): A method that advances the cursor to the next item and returns false if it reaches the end.

2) Current: A property that retrieves the item at the cursor's current position.

3) Reset(): A method that moves the cursor back to its initial position before the first element.

## What is Dynamic?
=> In C#, the dynamic keyword defines a type that bypasses static type checking at compile time. Instead, the operations
on a dynamic object are evaluated at runtime.

***Key Features of dynamic***

1) Runtime Evaluation: The compiler assumes the object supports any property, method, or operation. Errors are only 
thrown if the member does not exist during execution.

2) Variable Type Shifting: A variable declared as dynamic can change its underlying data type freely throughout its 
lifecycle.

3) Implicit Conversion: It automatically converts to and from any other data type without explicit casting.

4) Under the Hood: Internally, the compiler treats dynamic as the object type, but applies the Dynamic Language Runtime 
(DLR) to manage the calls.

***Syntax***
dynamic value = "Hello World";
Console.WriteLine(value.Length); // Works fine at runtime

// The compiler allows this call, even though 'Length' doesn't exist on integers
value = 123; 
// Console.WriteLine(value.Length); // This line compiles, but crashes at RUNTIME (RuntimeBinderException)

***Direct Comparison: dynamic vs var vs object***


| Feature                  | `dynamic`                     | `var`                          | `object`                                   |
|--------------------------|-------------------------------|--------------------------------|--------------------------------------------|
| **Type Bound At**        | Runtime                       | Compile-time                   | Compile-time                               |
| **Type Safety**          | Disables static checking.     | Full static checking.          | Full static checking.                      |
| **Casting Needed**       | No.                           | No.                            | Yes (to access specific properties).       |
| **Performance**          | Slower (due to DLR overhead). | Fast (same as explicit types). | Fast (requires explicit casting overhead). |


## What is Reflection?
=> In C#, Reflection is a feature that allows a program to inspect, discover, and interact with its own metadata and 
code structure at runtime.

It enables you to look inside assemblies, types, methods, and properties like an X-ray, and even execute code or 
instantiate objects dynamically.

***Real-World ApplicationsDependency Injection (DI) ***

1) Containers: Frameworks like .NET Core DI use reflection to find constructors and automatically inject services.

2) Object Mapping: Libraries like AutoMapper use it to copy values between different classes by matching property names.

3) JSON/XML Serializers: Tools like System.Text.Json read properties at runtime to convert objects into text payloads.

4) Unit Testing Frameworks: Tools like NUnit or xUnit scan assemblies for methods marked with [Test] or [Fact] attributes and execute them.


***Core Concepts of Reflection***

1) Metadata Inspection: You can read information about types (classes, structs, interfaces) without knowing about them at compile time.

2) Late Binding: You can instantiate objects and call their methods dynamically during execution.

3) The System.Type Class: This is the heart of reflection. It represents a type declaration.

4)The System.Reflection Namespace: Contains the classes needed to inspect assemblies, modules, fields, properties, and methods.
```

---

# Tags

`#csharp` `#dotnet` `#serialization` `#reflection` `#exceptions`
