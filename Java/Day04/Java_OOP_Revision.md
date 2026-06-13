# Java OOP Day 4 – Inheritance Revision Notes

## Topics Covered
- Inheritance
- extends Keyword
- Parent Class
- Child Class
- IS-A Relationship
- super Keyword
- Constructor Chaining
- Types of Inheritance
- Code Reusability

---

## What is Inheritance?
Inheritance is a mechanism through which one class acquires the properties and methods of another class.

### Real-Life Example
Vehicle
├── Car
├── Bike
└── Truck

Common features:
- color
- speed
- start()
- stop()

---

## Why Do We Need Inheritance?

Without inheritance, the same code is repeated in multiple classes.

Benefits:
- Code Reusability
- Less Duplication
- Easier Maintenance
- Better Design

---

## extends Keyword

```java
class Car extends Vehicle{

}
```

Meaning:

Car IS-A Vehicle

---

## Parent Class

Also called:
- Super Class
- Base Class
- Parent Class

```java
class Vehicle{

}
```

---

## Child Class

Also called:
- Sub Class
- Derived Class
- Child Class

```java
class Car extends Vehicle{

}
```

---

## Example

```java
class Vehicle{

    String color = "Red";

    void start(){
        System.out.println("Starting...");
    }
}

class Car extends Vehicle{

}
```

Car automatically inherits:
- color
- start()

---

## Constructor and Inheritance

```java
class Vehicle{

    Vehicle(){
        System.out.println("Vehicle Constructor");
    }
}

class Car extends Vehicle{

    Car(){
        System.out.println("Car Constructor");
    }
}
```

Output:

```text
Vehicle Constructor
Car Constructor
```

Rule:
Parent constructor executes first.

---

## super Keyword

super refers to the immediate parent class.

### Call Parent Constructor

```java
super();
```

### Access Parent Members

```java
super.color;
```

---

## Types of Inheritance

### Single Inheritance

Vehicle → Car

### Multilevel Inheritance

Vehicle → Car → SportsCar

### Hierarchical Inheritance

Vehicle → Car
Vehicle → Bike
Vehicle → Truck

### Multiple Inheritance

Not supported through classes in Java.

---

## IS-A Relationship

```java
class Car extends Vehicle
```

Car IS-A Vehicle

Examples:
- Dog IS-A Animal
- Manager IS-A Employee
- Bike IS-A Vehicle

---

## HAS-A Relationship

```java
class Car{

    Engine e;
}
```

Car HAS-A Engine

---

## Interview Questions

### What is Inheritance?
Inheritance is a mechanism through which one class acquires the properties and methods of another class.

### Which keyword is used?
extends

### What does super refer to?
Immediate parent class.

### Why use Inheritance?
For code reusability and reduced duplication.

---

## Quick Revision

✅ Inheritance

✅ extends

✅ Parent Class

✅ Child Class

✅ super Keyword

✅ IS-A Relationship

✅ HAS-A Relationship

✅ Constructor Chaining

✅ Single Inheritance

✅ Multilevel Inheritance

✅ Hierarchical Inheritance

✅ Multiple Inheritance (Not via Classes)

---

## Next Topic

Method Overriding

Runtime Polymorphism
