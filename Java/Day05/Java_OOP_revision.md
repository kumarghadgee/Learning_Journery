# Java OOP Day 6 – Abstraction Revision Notes

## Topics Covered

- Abstraction
- Abstract Class
- Abstract Method
- Runtime Polymorphism with Abstract Classes
- Interview Questions

---

# What is Abstraction?

Abstraction is the process of hiding implementation details and exposing only essential behavior.

### Real-Life Example

ATM Machine

Visible to User:

- Withdraw()
- Deposit()
- CheckBalance()

Hidden:

- Database Queries
- Server Communication
- Security Logic

The user only sees what is necessary.

---

# Why Do We Need Abstraction?

Suppose we have:

```java
Payment
├── CreditCardPayment
├── UpiPayment
└── NetBankingPayment
```

All payment methods must perform:

```java
pay()
```

But the parent class does not know how each payment type will implement the payment process.

Therefore:

- Parent defines the contract.
- Child classes provide the implementation.

---

# Abstract Class

A class declared using the `abstract` keyword.

### Syntax

```java
abstract class Animal{

}
```

### Important Rule

Cannot create objects.

```java
Animal a = new Animal(); // Error
```

---

# Abstract Method

A method without implementation.

### Syntax

```java
abstract void sound();
```

Characteristics:

- No method body
- Must be implemented by child classes

---

# Example

```java
abstract class Animal{

    abstract void sound();
}
```

```java
class Dog extends Animal{

    @Override
    void sound(){
        System.out.println("Bark");
    }
}
```

---

# Important Rule

If a child class inherits an abstract method, it must:

## Option 1: Implement It

```java
class Dog extends Animal{

    @Override
    void sound(){
        System.out.println("Bark");
    }
}
```

## Option 2: Become Abstract

```java
abstract class Dog extends Animal{

}
```

---

# Can Abstract Classes Have Constructors?

✅ Yes

```java
abstract class Animal{

    Animal(){
        System.out.println("Animal Constructor");
    }
}
```

---

# Can Abstract Classes Have Variables?

✅ Yes

```java
abstract class Animal{

    String name;
}
```

---

# Can Abstract Classes Have Normal Methods?

✅ Yes

```java
abstract class Animal{

    void eat(){
        System.out.println("Eating");
    }
}
```

---

# Runtime Polymorphism with Abstract Classes

```java
abstract class Animal{

    abstract void sound();
}
```

```java
class Dog extends Animal{

    @Override
    void sound(){
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

# Abstract Class vs Concrete Class

| Abstract Class | Concrete Class |
|---------------|---------------|
| Cannot Create Object | Can Create Object |
| Can Have Abstract Methods | Cannot Have Abstract Methods |
| Used as Blueprint | Used for Implementation |

---

# Interview Questions

## What is Abstraction?

Abstraction is the process of hiding implementation details and exposing only necessary functionality.

---

## What is an Abstract Class?

A class declared using the abstract keyword.

---

## What is an Abstract Method?

A method without implementation that must be implemented by child classes.

---

## Can We Create Objects of an Abstract Class?

No.

---

## Can Abstract Classes Have Constructors?

Yes.

---

## Can Abstract Classes Have Variables?

Yes.

---

## Can Abstract Classes Have Normal Methods?

Yes.

---

# Quick Revision Sheet

✅ Abstraction

✅ Abstract Class

✅ Abstract Method

✅ Constructors in Abstract Class

✅ Variables in Abstract Class

✅ Normal Methods in Abstract Class

✅ Runtime Polymorphism with Abstract Classes

✅ Interview Questions

---

# Key Interview Rule

If a class inherits an abstract method:

```java
abstract void sound();
```

Then the child class must:

1. Implement the method

OR

2. Become abstract

Otherwise the program will not compile.

---

# Next Topic

Interfaces

- Why Interfaces?
- Interface vs Abstract Class
- Multiple Inheritance using Interfaces
- Default Methods
- Static Methods