# Java Collections Day 4 – HashSet Revision Notes

## Topics Covered

- What is HashSet?
- Why HashSet?
- Internal Working
- Unique Elements
- Common Methods
- HashSet vs ArrayList
- Time Complexity
- Real World Applications
- Interview Questions

---

# Why HashSet?

Suppose we use an ArrayList:

```java
ArrayList<String> names = new ArrayList<>();

names.add("Rahul");
names.add("Amit");
names.add("Rahul");
```

Output:

```text
[Rahul, Amit, Rahul]
```

Problem:

- Duplicate values are allowed.
- Searching takes O(n) time.

---

# What is HashSet?

HashSet is a collection that stores only unique elements.

Characteristics:

```text
✅ Unique Elements
✅ Fast Search
✅ Fast Insert

❌ No Duplicates
❌ No Index
❌ No Guaranteed Order
```

---

# Package Required

```java
import java.util.HashSet;
```

---

# Creating a HashSet

```java
HashSet<Integer> set = new HashSet<>();
```

---

# Adding Elements

Use:

```java
add()
```

Example:

```java
set.add(10);
set.add(20);
set.add(30);
```

Output:

```text
[10, 20, 30]
```

---

# Duplicate Handling

```java
set.add(10);
set.add(20);
set.add(10);
set.add(30);
```

Output:

```text
[10, 20, 30]
```

The second `10` is ignored.

---

# Return Type of add()

```java
boolean result = set.add(10);
```

Returns:

```text
true
```

If element is added successfully.

---

```java
boolean result = set.add(10);
```

again returns:

```text
false
```

because the element already exists.

---

# contains()

Checks whether an element exists.

```java
set.contains(20);
```

Output:

```text
true
```

---

```java
set.contains(100);
```

Output:

```text
false
```

---

# remove()

Removes an element.

```java
set.remove(20);
```

Before:

```text
[10, 20, 30]
```

After:

```text
[10, 30]
```

---

# size()

Returns number of unique elements.

```java
System.out.println(set.size());
```

Example:

```java
10
20
10
30
```

Stored:

```text
10 20 30
```

Size:

```text
3
```

---

# Traversing HashSet

Enhanced For Loop:

```java
for(Integer num : set){
    System.out.println(num);
}
```

---

# Complete Example

```java
import java.util.HashSet;

public class Main {

    public static void main(String[] args) {

        HashSet<Integer> set = new HashSet<>();

        set.add(10);
        set.add(20);
        set.add(10);
        set.add(30);

        System.out.println(set);

        System.out.println(set.contains(20));

        set.remove(20);

        System.out.println(set);
    }
}
```

Output:

```text
[10, 20, 30]
true
[10, 30]
```

---

# HashSet vs ArrayList

| Feature | ArrayList | HashSet |
|----------|----------|----------|
| Duplicates | Allowed | Not Allowed |
| Index Access | Yes | No |
| Order Maintained | Yes | No |
| Search | O(n) | O(1) Average |
| Insert | O(1) Average | O(1) Average |

---

# Real World Applications

## Unique Usernames

Input:

```text
Rahul
Amit
Rahul
```

Output:

```text
Rahul
Amit
```

---

## Unique Email IDs

Input:

```text
abc@gmail.com
abc@gmail.com
xyz@gmail.com
```

Output:

```text
abc@gmail.com
xyz@gmail.com
```

---

## Finding Duplicate Elements

Input:

```text
1 2 3 2 4 5 1
```

Duplicates:

```text
1
2
```

HashSet is commonly used in interview questions.

---

# Time Complexity

| Operation | Complexity |
|------------|------------|
| add() | O(1) Average |
| contains() | O(1) Average |
| remove() | O(1) Average |
| search | O(1) Average |

---

# Interview Questions

## What is HashSet?

A collection that stores unique elements using hashing.

---

## Does HashSet allow duplicates?

No.

---

## Can we access elements using index?

No.

```java
set.get(0); // Error
```

---

## Does HashSet maintain insertion order?

No.

---

## What is the return type of add()?

```java
boolean
```

---

## Which package contains HashSet?

```java
java.util.HashSet
```

---

# Quick Revision Sheet

✅ Unique Elements Only

✅ No Duplicate Values

✅ Fast Search

✅ Fast Insert

✅ add()

✅ contains()

✅ remove()

✅ size()

✅ boolean return type of add()

❌ No Index

❌ No get()

❌ No Guaranteed Order

---

# Assignments

## Program 1

Create a HashSet and store:

```text
10, 20, 30, 20, 10, 40
```

Print unique values.

---

## Program 2

Take 5 integers from the user and store them in a HashSet.

Print all unique values.

---

## Program 3

Find duplicate numbers from:

```text
1 2 3 2 4 5 1
```

Expected Output:

```text
1
2
```

Hint:

```java
HashSet<Integer> seen = new HashSet<>();
HashSet<Integer> duplicates = new HashSet<>();
```

---

# Next Topic

## Java Collections Day 5 – HashMap

Topics:

- Key-Value Pairs
- put()
- get()
- remove()
- containsKey()
- containsValue()
- Real World Examples
- Frequency Count Problems
- Interview Questions