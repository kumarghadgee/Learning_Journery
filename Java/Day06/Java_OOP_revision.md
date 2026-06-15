# Java OOP Day 7 – Interfaces Revision Notes

## Topics Covered

- Introduction to Interfaces
- Implementing Interfaces
- Interface Methods
- Interface Variables
- CAN-DO Relationship
- Multiple Inheritance Using Interfaces
- Runtime Polymorphism with Interfaces
- Interface vs Abstract Class
- Default Methods
- Static Methods
- Interview Questions

---

# What is an Interface?

An Interface is a contract that tells a class what it must do.

It specifies behavior but does not provide implementation details.

### Syntax

```java
interface Camera {

    void capturePhoto();
}
```

---

# Why Interfaces?

Suppose we have:

```text
Camera
SmartPhone
Drone
```

All can:

```text
capturePhoto()
```

But:

```text
Camera IS-A SmartPhone ❌
Drone IS-A Camera ❌
```

Inheritance is not suitable here.

Interfaces allow unrelated classes to share common capabilities.

---

# Implementing an Interface

Use the `implements` keyword.

```java
interface Camera {

    void capturePhoto();
}
```

```java
class SmartPhone implements Camera {

    @Override
    public void capturePhoto() {
        System.out.println("Photo Captured");
    }
}
```

---

# Interface Methods

Methods inside an interface are:

```java
public abstract
```

by default.

Example:

```java
interface Camera {

    void capturePhoto();
}
```

Internally:

```java
interface Camera {

    public abstract void capturePhoto();
}
```

---

# Interface Variables

Variables inside an interface are:

```java
public static final
```

by default.

Example:

```java
interface Test {

    int X = 10;
}
```

Internally:

```java
public static final int X = 10;
```

Access:

```java
System.out.println(Test.X);
```

---

# CAN-DO Relationship

Inheritance represents:

```text
IS-A Relationship
```

Example:

```java
Car extends Vehicle
```

Car IS-A Vehicle.

---

Interfaces represent:

```text
CAN-DO Relationship
```

Example:

```java
Bird implements Flyable
```

Bird CAN Fly.

---

# Multiple Inheritance Using Interfaces

Java does not support multiple inheritance using classes.

❌ Not Allowed

```java
class Child extends Parent1, Parent2 {

}
```

---

✅ Allowed Using Interfaces

```java
interface A {

}

interface B {

}

class C implements A, B {

}
```

---

# Real World Example

```java
interface Camera {

    void capturePhoto();
}

interface MusicPlayer {

    void playMusic();
}

class SmartPhone
implements Camera, MusicPlayer {

    @Override
    public void capturePhoto() {
        System.out.println("Photo Captured");
    }

    @Override
    public void playMusic() {
        System.out.println("Playing Music");
    }
}
```

---

# Runtime Polymorphism with Interfaces

```java
interface Animal {

    void sound();
}
```

```java
class Dog implements Animal {

    @Override
    public void sound() {
        System.out.println("Bark");
    }
}
```

```java
Animal a = new Dog();

a.sound();
```

Output:

```text
Bark
```

---

# Default Methods (Java 8+)

Interfaces can contain methods with implementation using `default`.

```java
interface Camera {

    default void openCamera() {
        System.out.println("Opening Camera");
    }
}
```

Child classes can use this method directly.

---

# Static Methods in Interfaces

Interfaces can also contain static methods.

```java
interface MathUtil {

    static void display() {
        System.out.println("Hello");
    }
}
```

Call:

```java
MathUtil.display();
```

---

# Interface vs Abstract Class

| Interface | Abstract Class |
|------------|---------------|
| Contract | Partial Abstraction |
| Uses implements | Uses extends |
| Supports Multiple Inheritance | Does Not Support Multiple Inheritance |
| No Constructors | Constructors Allowed |
| No Instance Variables | Instance Variables Allowed |
| Methods are public abstract by default | Can Have Normal Methods |

---

# Interview Questions

## What is an Interface?

An interface is a contract that specifies what a class must do without specifying how it should do it.

---

## Which Keyword is Used?

```java
implements
```

---

## Can We Create Objects of an Interface?

No.

```java
Camera c = new Camera(); // Error
```

---

## Can a Class Implement Multiple Interfaces?

Yes.

```java
class SmartPhone implements Camera, MusicPlayer {

}
```

---

## What is the Default Modifier of Interface Methods?

```java
public abstract
```

---

## What is the Default Modifier of Interface Variables?

```java
public static final
```

---

## What Relationship Does an Interface Represent?

```text
CAN-DO Relationship
```

Example:

```java
Bird implements Flyable
```

Bird CAN Fly.

---

# Quick Revision Sheet

✅ Interface

✅ implements Keyword

✅ Contract-Based Design

✅ public abstract Methods

✅ public static final Variables

✅ CAN-DO Relationship

✅ Multiple Inheritance

✅ Runtime Polymorphism

✅ Default Methods

✅ Static Methods

✅ Interface vs Abstract Class

---

# OOP Journey Completed

✅ Class & Object

✅ Constructors

✅ Constructor Overloading

✅ this Keyword

✅ Encapsulation

✅ Getter & Setter

✅ Inheritance

✅ super Keyword

✅ Method Overriding

✅ Runtime Polymorphism

✅ Dynamic Method Dispatch

✅ Abstraction

✅ Abstract Class

✅ Abstract Method

✅ Interfaces

---

# Next Topic

## Java Collections Framework

Topics:

- ArrayList
- LinkedList
- Stack
- Queue
- HashSet
- HashMap
- Comparable
- Comparator
- Collections Interview Questions