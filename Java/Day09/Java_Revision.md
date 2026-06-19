# Java Collections Day 5 – Comparable & Comparator Revision Notes

## Topics Covered

- Sorting in Java Collections
- Collections.sort()
- Comparable Interface
- Comparator Interface
- compareTo()
- compare()
- Natural Ordering
- Custom Ordering
- Comparable vs Comparator
- Interview Questions

---

# Why Do We Need Sorting?

Suppose we have:

```java
ArrayList<Integer> list = new ArrayList<>();

list.add(30);
list.add(10);
list.add(20);
```

Output:

```text
[30, 10, 20]
```

To sort:

```java
Collections.sort(list);
```

Output:

```text
[10, 20, 30]
```

---

# Problem with Custom Objects

Consider:

```java
class Student{
    int rollNo;
    String name;
    double marks;
}
```

Now Java does not know:

```text
Should I sort by Roll Number?
Should I sort by Name?
Should I sort by Marks?
```

To solve this, Java provides:

```text
Comparable
Comparator
```

---

# Comparable Interface

Comparable is used when a class has a default sorting rule.

Example:

```java
class Student implements Comparable<Student>
```

You must override:

```java
compareTo()
```

---

# compareTo() Method

Syntax:

```java
@Override
public int compareTo(Student s) {
    return this.rollNo - s.rollNo;
}
```

Meaning:

```text
Sort Students by Roll Number
```

---

# Example of Comparable

```java
import java.util.*;

class Student implements Comparable<Student>{

    int rollNo;
    String name;

    public Student(int rollNo, String name){
        this.rollNo = rollNo;
        this.name = name;
    }

    @Override
    public int compareTo(Student s){
        return this.rollNo - s.rollNo;
    }

    @Override
    public String toString(){
        return rollNo + " " + name;
    }
}
```

Sorting:

```java
Collections.sort(studentList);
```

Output:

```text
101 Rahul
102 Kumar
103 Amit
```

---

# Comparator Interface

Comparator is used when we want custom sorting.

Examples:

```text
Sort by Name
Sort by Marks
Sort by Salary
Sort by Age
```

without modifying the original class.

---

# compare() Method

Syntax:

```java
@Override
public int compare(Student s1, Student s2){
    return s1.name.compareTo(s2.name);
}
```

Meaning:

```text
Sort by Name
```

---

# Comparator Example

```java
import java.util.Comparator;

class NameComparator implements Comparator<Student>{

    @Override
    public int compare(Student s1, Student s2){
        return s1.name.compareTo(s2.name);
    }
}
```

Sorting:

```java
Collections.sort(list, new NameComparator());
```

Output:

```text
103 Amit
102 Kumar
101 Rahul
```

---

# Sorting by Marks (Descending)

```java
class MarksComparator implements Comparator<Student>{

    @Override
    public int compare(Student s1, Student s2){
        return Double.compare(s2.marks, s1.marks);
    }
}
```

Output:

```text
103 Amit 92
101 Rahul 85
102 Kumar 78
```

---

# Natural Ordering

Default sorting order defined inside the class.

Example:

```text
Student sorted by Roll Number
```

Implemented using:

```java
Comparable
```

---

# Custom Ordering

Sorting based on user requirement.

Examples:

```text
Name
Marks
Salary
Age
```

Implemented using:

```java
Comparator
```

---

# Comparable vs Comparator

| Comparable | Comparator |
|------------|------------|
| Inside Class | Outside Class |
| compareTo() | compare() |
| Natural Ordering | Custom Ordering |
| Single Sorting Rule | Multiple Sorting Rules |
| Less Flexible | More Flexible |

---

# Real World Examples

## Employee Management System

Employee:

```text
101 Rahul 50000
102 Amit 70000
103 Kumar 60000
```

Possible Sorting:

```text
By Employee ID
By Name
By Salary
```

Comparator is preferred.

---

## Student Management System

Student:

```text
101 Rahul 85
102 Kumar 78
103 Amit 92
```

Possible Sorting:

```text
By Roll Number
By Name
By Marks
```

Comparator is preferred.

---

# Interview Questions

## What is Comparable?

Comparable is used to define a default sorting rule for a class.

---

## Which method belongs to Comparable?

```java
compareTo()
```

---

## What is Comparator?

Comparator is used for custom sorting.

---

## Which method belongs to Comparator?

```java
compare()
```

---

## Which one supports multiple sorting logics?

```java
Comparator
```

---

## Which one is used for Natural Ordering?

```java
Comparable
```

---

## Which one is more flexible?

```java
Comparator
```

---

# Quick Revision Sheet

```text
Comparable
-----------
✔ Default Sorting
✔ Natural Ordering
✔ compareTo()
✔ Inside Class

Comparator
-----------
✔ Custom Sorting
✔ Multiple Sorting Rules
✔ compare()
✔ Outside Class

Examples
--------
Roll Number → Comparable
Name → Comparator
Marks → Comparator
Salary → Comparator
```

---

# Mentor Notes

Remember:

```text
Comparable = One Default Sorting Rule

Comparator = Many Custom Sorting Rules
```

Interview Shortcut:

```text
Roll Number -> Comparable

Name, Marks, Salary, Age
-> Comparator
```

---

# Practice Assignment

## Task 1

Create Student class:

```java
int rollNo;
String name;
double marks;
```

Implement:

```java
Comparable<Student>
```

Sort by:

```text
Roll Number
```

---

## Task 2

Create Comparator:

```java
NameComparator
```

Sort by:

```text
Name
```

---

## Task 3

Create Comparator:

```java
MarksComparator
```

Sort by:

```text
Marks Descending
```

---

# Collections Progress

```text
✅ ArrayList
✅ LinkedList
✅ Stack
✅ Queue
✅ HashSet
✅ HashMap
✅ Comparable
✅ Comparator
```

# Next Topic

## Java Collections Day 6 – Iterator & ListIterator

Topics:

- Iterator
- ListIterator
- hasNext()
- next()
- remove()
- Forward Traversal
- Backward Traversal
- ConcurrentModificationException
- Interview Questions