# Java OOP Phase 1 Revision Notes

## Topics Covered

- Class
- Object
- Reference Variable
- Heap Memory
- Constructor
- Default Constructor
- Parameterized Constructor
- this Keyword
- Constructor Overloading
- Encapsulation
- Getter & Setter
- Access Modifiers

---

# 1. What is OOP?

OOP (Object-Oriented Programming) is a programming paradigm that models real-world entities using Objects and Classes.

Benefits:

- Code Reusability
- Modularity
- Security
- Maintainability
- Scalability

---

# 2. Class

A Class is a blueprint or template used to create objects.

### Syntax

```java
class Student{

}
```

### Real Life Example

```text
Blueprint → House
Class     → Student
Object    → Actual Student
```

### Interview Definition

A class is a logical entity that defines properties and behaviors of an object.

---

# 3. Object

An Object is an instance of a class.

### Syntax

```java
Student s1 = new Student();
```

### Breakdown

```java
Student s1 = new Student();
```

| Part | Meaning |
|--------|--------|
| Student | Class |
| s1 | Reference Variable |
| new Student() | Object Creation |

### Interview Definition

An object is a physical entity and an instance of a class that occupies memory.

---

# 4. Attributes and Methods

### Attributes (Instance Variables)

```java
class Student{

    String name;
    int age;
    double percentage;
}
```

Attributes store data.

---

### Methods

```java
class Student{

    void display(){
        System.out.println("Student Details");
    }
}
```

Methods define behavior.

---

# 5. Reference Variable

```java
Student s1 = new Student();
```

Here:

```java
s1
```

is a reference variable.

It stores the address/reference of the object.

---

# 6. Heap and Stack Memory

### Stack Memory

Stores:

- Reference Variables
- Local Variables

### Heap Memory

Stores:

- Objects

Example:

```java
Student s1 = new Student();
```

Visualization:

```text
Stack                 Heap

s1  ----------->   Student Object
```

---

# 7. Constructor

A Constructor is a special member of a class that executes automatically when an object is created.

### Syntax

```java
class Student{

    Student(){
        System.out.println("Object Created");
    }
}
```

### Object Creation

```java
Student s1 = new Student();
```

Output:

```text
Object Created
```

---

# Constructor Rules

### Rule 1

Constructor name must be same as class name.

```java
Student(){

}
```

### Rule 2

Constructor has no return type.

Correct:

```java
Student(){

}
```

Wrong:

```java
void Student(){

}
```

---

# 8. Default Constructor

If no constructor is written by the programmer, Java provides one automatically.

Example:

```java
class Student{

}
```

Java internally provides:

```java
Student(){

}
```

This is called the Default Constructor.

---

# 9. Parameterized Constructor

Used to initialize object data during object creation.

### Example

```java
class Student{

    String name;
    int age;

    Student(String name,int age){
        this.name = name;
        this.age = age;
    }
}
```

Object Creation:

```java
Student s1 = new Student("Kumar",21);
```

---

# 10. this Keyword

### Definition

this refers to the current object.

### Example

```java
class Student{

    String name;

    Student(String name){
        this.name = name;
    }
}
```

### Why?

Wrong:

```java
Student(String name){
    name = name;
}
```

Both variables refer to parameter.

Correct:

```java
this.name = name;
```

---

# 11. Constructor Overloading

Multiple constructors in the same class with different parameter lists.

### Example

```java
class Student{

    Student(){

    }

    Student(String name){

    }

    Student(String name,int age){

    }
}
```

### Why Use It?

Allows object creation in multiple ways.

```java
new Student();

new Student("Kumar");

new Student("Kumar",21);
```

### Interview Definition

Constructor Overloading is the process of creating multiple constructors with different parameters in the same class.

---

# 12. Encapsulation

### Definition

Encapsulation is the process of wrapping data and methods into a single unit and restricting direct access to data.

### Example

```java
class Student{

    private int age;

    public void setAge(int age){
        this.age = age;
    }

    public int getAge(){
        return age;
    }
}
```

---

# Why Encapsulation?

Without Encapsulation:

```java
s.age = -10;
```

Invalid data can enter the object.

With Encapsulation:

```java
setAge()
```

can validate data.

Example:

```java
public void setAge(int age){

    if(age > 0){
        this.age = age;
    }
}
```

---

# 13. Getter and Setter

### Getter

Used to read data.

```java
public int getAge(){
    return age;
}
```

---

### Setter

Used to modify data.

```java
public void setAge(int age){
    this.age = age;
}
```

---

# 14. Access Modifiers

## Private

Accessible only inside the same class.

```java
private int age;
```

---

## Public

Accessible from anywhere.

```java
public void display(){

}
```

---

# Interview Questions

## What is a Class?

A class is a blueprint or template used to create objects.

---

## What is an Object?

An object is an instance of a class.

---

## What does new do?

- Creates an object
- Allocates memory in heap
- Returns object reference

---

## What is a Constructor?

A special member that executes automatically when an object is created.

---

## What is Constructor Overloading?

Creating multiple constructors with different parameter lists.

---

## What does this refer to?

Current object.

---

## What is Encapsulation?

Wrapping data and methods into a single unit while restricting direct access to data.

---

## Why use private variables?

- Data Hiding
- Security
- Validation
- Controlled Access

---

# Quick Revision Sheet

✅ Class

✅ Object

✅ Instance Variable

✅ Methods

✅ Reference Variable

✅ Heap Memory

✅ Constructor

✅ Default Constructor

✅ Parameterized Constructor

✅ this Keyword

✅ Constructor Overloading

✅ Encapsulation

✅ Getter

✅ Setter

✅ private

✅ public

---

# Next Topic

Inheritance

Example:

Vehicle
├── Car
├── Bike
└── Truck

Goal:
Learn code reusability using extends keyword.
