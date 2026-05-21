# C# Day 04 Notes 🚀
## Events, Delegates, Arrays & Collections in C#

---

# Table of Contents

1. Events in C#
2. EventHandler Delegate
3. Generic Delegates
4. Delegate vs Event
5. Arrays in C#
6. Types of Arrays
7. Collections in C#
8. Quick Revision Summary

---

# 1. Events in C#

## What is an Event?

An **Event** is a mechanism used for communication between objects.

It allows one object to notify another object when something happens.

---

# Publisher-Subscriber Model

```text
Publisher
    ↓ Raises Event
Subscribers
    ↓ Handle Event
```

---

# Basic Event Syntax

```csharp
public delegate void Notify();

public event Notify OnNotify;
```

---

# Event Flow Diagram

```text
Event Occurs
      ↓
Publisher Raises Event
      ↓
Subscribers Notified
      ↓
Handlers Execute
```

---

# 2. EventHandler Delegate

## Standard Signature

```csharp
void Handler(object sender, EventArgs e)
{
}
```

---

# Parameters

| Parameter | Meaning |
|---|---|
| sender | Object raising event |
| e | Event data |

---

# Example

```csharp
class Demo
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}
```

---

# 3. Generic Delegates

## What are Generic Delegates?

Generic delegates use type parameters (`<T>`) to make delegates reusable.

---

# User-Defined Generic Delegates

```csharp
delegate void Consumer<T>(T obj);
delegate T Supplier<T>();
delegate R Function<T,R>(T obj);
delegate bool Condition<T>(T obj);
```

---

# Built-In Generic Delegates

| Delegate | Purpose |
|---|---|
| Action<T> | No return value |
| Func<T,R> | Returns value |
| Predicate<T> | Returns bool |

---

# Examples

```csharp
Action<string> show = Console.WriteLine;

Func<string, int> parser = int.Parse;

Predicate<int> isEven = x => x % 2 == 0;
```

---

# 4. Delegate vs Event

| Feature | Delegate | Event |
|---|---|---|
| Purpose | Function pointer | Notification mechanism |
| Keyword | delegate | event |
| Invocation | Anywhere | Inside declaring class only |
| Assignment | Allowed | Restricted |

---

# 5. Arrays in C#

## What is an Array?

An array stores multiple values of the same datatype in contiguous memory locations.

---

# Array Syntax

```csharp
int[] nums = new int[5];
```

---

# Array Flow

```text
Declare Array
      ↓
Allocate Memory
      ↓
Store Values
      ↓
Access Using Index
```

---

# Types of Arrays

## 1. Single-Dimensional Array

```csharp
string[] days = { "Mon", "Tue", "Wed" };
```

---

## 2. Multi-Dimensional Array

```csharp
int[,] matrix =
{
    {1,2,3},
    {4,5,6}
};
```

---

## 3. Jagged Array

```csharp
int[][] arr = new int[3][];

arr[0] = new int[] {1,2};
arr[1] = new int[] {3,4,5};
```

---

# Jagged vs Rectangular

| Feature | Rectangular | Jagged |
|---|---|---|
| Structure | Matrix | Array of arrays |
| Row Size | Same | Different |
| Memory | Single block | Separate blocks |

---

# 6. Collections in C#

## What are Collections?

Collections are specialized classes used to store and manage groups of objects dynamically.

---

# Collection Categories

```text
Collections
│
├── Generic Collections
├── Non-Generic Collections
└── Concurrent Collections
```

---

# Common Collections

## List<T>

```csharp
List<int> nums = new List<int>();
```

Dynamic array.

---

## Dictionary<TKey,TValue>

```csharp
Dictionary<int, string> students;
```

Key-value storage.

---

## Queue<T>

FIFO structure.

```text
First In → First Out
```

---

## Stack<T>

LIFO structure.

```text
Last In → First Out
```

---

## HashSet<T>

Stores unique values.

```csharp
HashSet<int> set;
```

---

# Real-World Use Cases

| Collection | Example |
|---|---|
| List | Student records |
| Queue | Printer queue |
| Stack | Browser history |
| Dictionary | User database |
| HashSet | Unique email storage |

---

# Quick Revision Summary

| Concept | Purpose |
|---|---|
| Event | Notification mechanism |
| Delegate | Function pointer |
| Generic Delegate | Reusable delegate |
| Array | Fixed-size storage |
| Collection | Dynamic storage |
| Queue | FIFO |
| Stack | LIFO |

---

# One-Line Memory Tricks 🧠

```text
Event → Notify something happened
Delegate → Store method reference
Array → Fixed-size storage
Collection → Dynamic storage
Queue → FIFO
Stack → LIFO
Dictionary → Key-Value mapping
```

---

# Tags

`#csharp` `#dotnet` `#events` `#delegates` `#collections`
