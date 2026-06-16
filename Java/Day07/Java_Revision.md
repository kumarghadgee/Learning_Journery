# Java Collections Day 2 – LinkedList Revision Notes

## Topics Covered

- What is LinkedList?
- Why LinkedList?
- Internal Working of LinkedList
- Node Structure
- Creating a LinkedList
- Common Methods
- ArrayList vs LinkedList
- Time Complexity
- Interview Questions

---

# Why LinkedList?

ArrayList is good for:

- Fast Index Access
- Reading Data

But ArrayList is not efficient for:

- Frequent Insertions
- Frequent Deletions

Especially at the beginning.

Example:

Before:

```text
[10, 20, 30, 40, 50]
```

Insert:

```text
5
```

After:

```text
[5, 10, 20, 30, 40, 50]
```

All elements shift one position.

This takes:

```text
O(n)
```

time.

---

# What is LinkedList?

LinkedList is a linear data structure where elements are stored as nodes.

Each node contains:

```text
Data + Address of Next Node
```

Unlike arrays, elements are not stored in contiguous memory locations.

---

# Structure of a Node

```text
┌──────┬─────────┐
│ Data │ Next    │
└──────┴─────────┘
```

Example:

```text
[10|•] → [20|•] → [30|null]
```

---

# Internal Working

Suppose we store:

```text
10, 20, 30
```

LinkedList stores:

```text
10 → 20 → 30 → null
```

Where:

- Each node stores data
- Each node stores reference of next node

---

# Creating a LinkedList

```java
import java.util.LinkedList;

LinkedList<Integer> list = new LinkedList<>();
```

---

# Adding Elements

## add()

```java
list.add(10);
list.add(20);
list.add(30);
```

Output:

```text
[10, 20, 30]
```

---

# Add First

```java
list.addFirst(5);
```

Output:

```text
[5, 10, 20, 30]
```

---

# Add Last

```java
list.addLast(40);
```

Output:

```text
[5, 10, 20, 30, 40]
```

---

# Access Elements

## getFirst()

```java
System.out.println(list.getFirst());
```

Output:

```text
5
```

---

## getLast()

```java
System.out.println(list.getLast());
```

Output:

```text
40
```

---

# Removing Elements

## removeFirst()

```java
list.removeFirst();
```

Before:

```text
[5, 10, 20, 30]
```

After:

```text
[10, 20, 30]
```

---

## removeLast()

```java
list.removeLast();
```

Before:

```text
[10, 20, 30]
```

After:

```text
[10, 20]
```

---

# Complete Example

```java
import java.util.LinkedList;

public class Main {

    public static void main(String[] args) {

        LinkedList<Integer> list = new LinkedList<>();

        list.add(10);
        list.add(20);
        list.add(30);

        list.addFirst(5);

        list.addLast(40);

        System.out.println(list);

        System.out.println("First : " + list.getFirst());

        System.out.println("Last : " + list.getLast());
    }
}
```

Output:

```text
[5, 10, 20, 30, 40]
First : 5
Last : 40
```

---

# ArrayList vs LinkedList

| Feature | ArrayList | LinkedList |
|----------|------------|------------|
| Internal Structure | Dynamic Array | Nodes |
| Random Access | Fast O(1) | Slow O(n) |
| Insert at Beginning | O(n) | O(1) |
| Delete at Beginning | O(n) | O(1) |
| Memory Usage | Less | More |
| Searching | O(n) | O(n) |

---

# When to Use ArrayList?

Choose ArrayList when:

- Reading data frequently
- Random access is needed
- Insertions/deletions are rare

Example:

```text
Student Records
Product Catalog
Employee List
```

---

# When to Use LinkedList?

Choose LinkedList when:

- Frequent insertion is required
- Frequent deletion is required
- Data changes often

Example:

```text
Music Playlist
Browser History
Undo/Redo Feature
Queue Management
```

---

# Time Complexity

| Operation | ArrayList | LinkedList |
|------------|------------|------------|
| Access by Index | O(1) | O(n) |
| Insert at Beginning | O(n) | O(1) |
| Delete at Beginning | O(n) | O(1) |
| Search | O(n) | O(n) |

---

# Interview Questions

## What is LinkedList?

A LinkedList is a linear data structure where elements are stored as nodes connected through references.

---

## What does a node contain?

```text
Data + Reference of Next Node
```

---

## Which package contains LinkedList?

```java
java.util.LinkedList
```

---

## Which method adds an element at the beginning?

```java
addFirst()
```

---

## Which method adds an element at the end?

```java
addLast()
```

---

## Which method returns the first element?

```java
getFirst()
```

---

## Which method returns the last element?

```java
getLast()
```

---

## Which is better for frequent insertion?

```text
LinkedList
```

Reason:

No shifting of elements.

---

# Mentor Notes

Important Understanding:

ArrayList:

```text
[10,20,30,40]
```

Insert at beginning:

```text
Shift all elements
```

Time:

```text
O(n)
```

---

LinkedList:

```text
10 → 20 → 30 → 40
```

Insert at beginning:

```text
Create new node and update reference
```

Time:

```text
O(1)
```

---

# Quick Revision Sheet

✅ LinkedList

✅ Node

✅ Data + Next Reference

✅ add()

✅ addFirst()

✅ addLast()

✅ getFirst()

✅ getLast()

✅ removeFirst()

✅ removeLast()

✅ ArrayList vs LinkedList

✅ O(1) Insertion at Beginning

✅ O(n) Random Access

---

# Assignments

## Program 1

Create a LinkedList and store:

```text
10, 20, 30, 40, 50
```

Print all elements.

---

## Program 2

Use:

```java
addFirst()
addLast()
```

and print the LinkedList.

---

## Program 3

Print:

- First Element
- Last Element

using:

```java
getFirst()
getLast()
```

---

# Next Topic

## Java Collections Day 3 – Stack & Queue

Topics:

- Stack
- LIFO
- Queue
- FIFO
- push()
- pop()
- peek()
- offer()
- poll()
- Real World Examples
- Interview Questions