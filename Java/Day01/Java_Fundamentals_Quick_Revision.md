# Java Fundamentals - Quick Revision Notes (Day 1 to Day 3)

---

# Day 1: Variables, Data Types, Input/Output, Scanner, Type Casting

## What is a Variable?

A variable is a named memory location used to store data.

```java
int age = 21;
String name = "Kumar";
```

## Primitive Data Types

| Data Type | Description | Example |
|------------|------------|----------|
| byte | Small integer | 100 |
| short | Medium integer | 2000 |
| int | Integer | 21 |
| long | Large integer | 100000L |
| float | Decimal | 10.5f |
| double | Decimal (more precision) | 99.99 |
| char | Single character | 'A' |
| boolean | True/False | true |

## Scanner

```java
Scanner sc = new Scanner(System.in);
int age = sc.nextInt();
String name = sc.nextLine();
```

## Type Casting

### Implicit Casting
```java
int num = 10;
double value = num;
```

### Explicit Casting
```java
double price = 99.99;
int amount = (int) price;
```

---

# Day 2: Operators

## Arithmetic Operators

`+  -  *  /  %`

## Relational Operators

`==  !=  >  <  >=  <=`

## Logical Operators

`&&  ||  !`

## Assignment Operators

`=  +=  -=  *=  /=`

## Increment / Decrement

### Post Increment
```java
a++;
```

Use first, then increase.

### Pre Increment
```java
++a;
```

Increase first, then use.

### Modulus Operator

Returns the remainder.

```java
10 % 3 = 1
20 % 5 = 0
```

---

# Day 3: Conditional Statements

## if

```java
if(age >= 18){
    System.out.println("Eligible");
}
```

## if-else

```java
if(age >= 18){
    System.out.println("Eligible");
}else{
    System.out.println("Not Eligible");
}
```

## else-if

```java
if(marks >= 90){
    System.out.println("A");
}
else if(marks >= 80){
    System.out.println("B");
}
```

## Nested if

```java
if(age >= 18){
    if(hasLicense){
        System.out.println("Can Drive");
    }
}
```

## switch

```java
switch(day){
    case 1:
        System.out.println("Monday");
        break;
}
```

## Fall Through

Without `break`, execution continues to the next case.

## Common Programs

### Even / Odd

```java
if(num % 2 == 0){
    System.out.println("Even");
}
```

### Positive / Negative / Zero

```java
if(num > 0){
    System.out.println("Positive");
}else if(num < 0){
    System.out.println("Negative");
}else{
    System.out.println("Zero");
}
```

### Largest of Three Numbers

```java
if(a >= b && a >= c){
    System.out.println(a);
}
else if(b >= a && b >= c){
    System.out.println(b);
}
else{
    System.out.println(c);
}
```

### Leap Year

```java
if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)){
    System.out.println("Leap Year");
}
```

---

# Interview Revision

## next() vs nextLine()

- next() → One word
- nextLine() → Complete line

## a++ vs ++a

- a++ → Use then Increase
- ++a → Increase then Use

## switch Limitation

Traditional switch does not support boolean.

---

# End of Notes
