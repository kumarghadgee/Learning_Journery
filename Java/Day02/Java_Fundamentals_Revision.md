# Java Fundamentals - Day 04 Revision Notes (Loops & Number Logic)

## Topics Covered
- for Loop
- while Loop
- do-while Loop
- break Statement
- Sum of N Numbers
- Count Digits
- Reverse Number
- Palindrome Number

---

# 1. for Loop

Used when the number of iterations is known.

```java
for(int i = 1; i <= 5; i++){
    System.out.print(i + " ");
}
```

### Components of for Loop

```java
for(initialization; condition; increment/decrement)
```

Example:

```java
for(int i = 1; i <= 5; i++)
```

- Initialization → `int i = 1`
- Condition → `i <= 5`
- Increment → `i++`

Output:

```text
1 2 3 4 5
```

---

# 2. while Loop

Checks the condition before execution.

```java
int i = 1;

while(i <= 5){
    System.out.println(i);
    i++;
}
```

---

# 3. do-while Loop

Executes at least once before checking the condition.

```java
int i = 1;

do{
    System.out.println(i);
    i++;
}while(i <= 5);
```

---

# while vs do-while

| while | do-while |
|---------|---------|
| Checks condition first | Executes first |
| May run 0 times | Runs at least once |

Example:

```java
int i = 10;

while(i < 5){
    System.out.println(i);
}
```

Output:

```text
No Output
```

Example:

```java
int i = 10;

do{
    System.out.println(i);
}while(i < 5);
```

Output:

```text
10
```

---

# 4. break Statement

Used to terminate a loop immediately.

```java
for(int i = 1; i <= 5; i++){

    if(i == 3){
        break;
    }

    System.out.print(i + " ");
}
```

Output:

```text
1 2
```

---

# 5. Print Numbers

## Print 1 to 10

```java
for(int i = 1; i <= 10; i++){
    System.out.println(i);
}
```

## Print 10 to 1

```java
for(int i = 10; i >= 1; i--){
    System.out.println(i);
}
```

## Print Even Numbers

```java
for(int i = 2; i <= 20; i += 2){
    System.out.println(i);
}
```

---

# 6. Sum of First N Numbers

```java
int sum = 0;

for(int i = 1; i <= n; i++){
    sum += i;
}
```

### Optimized Formula

```text
Sum = n × (n + 1) / 2
```

### Complexity

```text
O(N)
```

Optimized:

```text
O(1)
```

---

# 7. Count Digits

Input:

```text
12345
```

Output:

```text
5
```

Logic:

```java
int count = 0;

while(num > 0){
    count++;
    num /= 10;
}
```

### Complexity

```text
O(d)
```

where d = number of digits.

---

# 8. Reverse Number

Input:

```text
1234
```

Output:

```text
4321
```

Logic:

```java
int rev = 0;

while(num > 0){
    int digit = num % 10;
    rev = rev * 10 + digit;
    num /= 10;
}
```

### Dry Run

| num | digit | rev |
|------|------|------|
| 1234 | 4 | 4 |
| 123 | 3 | 43 |
| 12 | 2 | 432 |
| 1 | 1 | 4321 |

### Complexity

```text
O(d)
```

---

# 9. Palindrome Number

A number is palindrome if it remains the same after reversing.

Examples:

```text
121  → Palindrome
1331 → Palindrome
123  → Not Palindrome
```

Logic:

```java
int original = num;

// Reverse the number

if(original == rev){
    System.out.println("Palindrome");
}
else{
    System.out.println("Not Palindrome");
}
```

### Complexity

```text
O(d)
```

---

# Common Interview Questions

## Q1. Difference between while and do-while?

### while
- Checks condition first.
- May execute 0 times.

### do-while
- Executes first.
- Executes at least once.

---

## Q2. What is an Infinite Loop?

A loop whose condition never becomes false.

Example:

```java
while(true){
    System.out.println("Hello");
}
```

---

## Q3. What does break do?

Immediately terminates the loop.

---

## Q4. What are the three parts of a for loop?

- Initialization
- Condition
- Increment / Decrement

---

# Quick Revision Sheet

✅ for Loop

✅ while Loop

✅ do-while Loop

✅ break Statement

✅ Print 1 to 10

✅ Print 10 to 1

✅ Print Even Numbers

✅ Sum of N Numbers

✅ Count Digits

✅ Reverse Number

✅ Palindrome Number

---

# Day 04 Completed

You should now be able to solve:

- Sum of N Numbers
- Count Digits
- Reverse Number
- Palindrome Number

without looking at notes.

These problems are the foundation of Number Logic and DSA.