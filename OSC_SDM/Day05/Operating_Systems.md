# Operating Systems – Quick Revision Notes

## 1. Memory Management

* Allows multiple processes to run simultaneously in RAM.
* Depends on hardware support provided by the MMU (Memory Management Unit).
* Main schemes:

  1. Contiguous Allocation
  2. Segmentation
  3. Paging

---

# 2. Contiguous Allocation

## Fixed Partitioning

* RAM divided into fixed-size partitions.
* One process per partition.

### Advantages

* Simple implementation.

### Disadvantages

* Number of processes limited by partitions.
* Process size limited by partition size.
* Causes **Internal Fragmentation**.

### Internal Fragmentation

Unused memory inside an allocated partition.

---

## Dynamic Partitioning

* Memory allocated according to process size.
* Free memory blocks (holes) maintained by OS.

### Allocation Algorithms

#### First Fit

* First block large enough is allocated.
* Fastest.

#### Best Fit

* Smallest suitable block allocated.
* Better memory utilization.

#### Worst Fit

* Largest free block allocated.
* Leaves larger free blocks.

### External Fragmentation

Enough total memory exists but not in one contiguous block.

### Compaction

Moving processes to combine free spaces into one large block.

---

# 3. Virtual Memory

* Disk space used as an extension of RAM.
* Also called **Swap Space** or **Swap Area**.

### Swap Out

RAM → Disk

### Swap In

Disk → RAM

### Advantages

* Run more programs.
* Run larger programs than RAM size.

---

# 4. Segmentation

* Process divided into logical segments:

  * Code
  * Data
  * Stack
  * Heap

### Address Format

```text
(Segment Number, Offset)
```

### Segment Table

Stores:

* Base Address
* Limit (Size)
* Permissions
* Valid Bit

### Physical Address

```text
Physical Address = Base + Offset
```

### Demand Segmentation

Segment loaded into RAM only when required.

---

# 5. Paging

## Basic Concepts

### Frame

Fixed-size block in RAM.

### Page

Fixed-size block of process memory.

```text
Page Size = Frame Size
```

### Advantages

* Eliminates External Fragmentation.

### Disadvantage

* Internal Fragmentation may occur.

---

# 6. Page Table

Maps:

```text
Page Number → Frame Number
```

Each process has its own page table.

### PTBR

Page Table Base Register

Stores address of page table.

---

# 7. TLB (Translation Lookaside Buffer)

High-speed cache storing recent page-to-frame mappings.

### TLB Hit

Translation found in TLB.

### TLB Miss

Page table accessed.

Benefit:

* Faster address translation.

---

# 8. Two-Level Paging

Virtual Address:

```text
| P1 | P2 | Offset |
```

For 32-bit systems:

```text
P1 = 10 bits
P2 = 10 bits
Offset = 12 bits
```

Reduces memory used by page tables.

---

# 9. Demand Paging

Pages loaded into RAM only when needed.

Benefits:

* Reduced memory usage.
* Faster program startup.

---

# 10. Page Fault

Occurs when requested page is not in RAM.

### Reasons

* Invalid address.
* Swapped-out page.
* Unallocated page.

### Handling Steps

1. Check validity.
2. Find free frame.
3. Load page from disk.
4. Update page table.
5. Restart instruction.

---

# 11. Thrashing

Excessive page swapping between RAM and disk.

### Causes

* Too many processes.
* Insufficient RAM.

### Solution

* Increase RAM.
* Reduce degree of multiprogramming.

---

# 12. Page Replacement Algorithms

Used when no free frame exists.

## FIFO

* Oldest page removed first.

### Belady's Anomaly

More frames may increase page faults.

---

## Optimal

* Remove page used farthest in future.
* Minimum page faults.
* Not practical.

---

## LRU (Least Recently Used)

* Remove page not used for longest time.
* Widely used.

---

# 13. Dirty Bit

Stored in Page Table Entry (PTE).

### Dirty = 0

Page not modified.

### Dirty = 1

Page modified.

Benefit:

* Avoid unnecessary disk writes.

---

# 14. Process Creation

## System Calls

### Windows

```c
CreateProcess()
```

### UNIX/Linux

```c
fork()
```

---

# 15. fork()

Creates a child process.

```c
pid = fork();
```

Returns:

| Process | Return Value |
| ------- | ------------ |
| Parent  | Child PID    |
| Child   | 0            |
| Failure | -1           |

---

# 16. Orphan Process

Parent terminates before child.

Child adopted by:

```text
init / systemd
```

---

# 17. Zombie Process

Child terminates but parent has not collected exit status.

Characteristics:

* Memory released.
* PCB remains.

---

# 18. wait()

```c
wait(&status);
```

Functions:

* Wait for child termination.
* Read exit status.
* Remove zombie process.

---

# 19. exec()

Loads a new program into current process.

```c
exec(...)
```

Characteristics:

* Replaces current process image.
* Does not return on success.

Common usage:

```text
fork() → exec()
```

---

# 20. Synchronization

### Race Condition

Occurs when multiple processes access shared data simultaneously.

### Critical Section

Code accessing shared resources.

Only one process should execute it at a time.

---

# 21. Semaphore

Synchronization primitive based on a counter.

## Operations

### wait() / P()

* Decrement counter.
* Block if counter < 0.

### signal() / V()

* Increment counter.
* Wake blocked process.

---

## Types of Semaphores

### Counting Semaphore

Allows multiple resource instances.

### Binary Semaphore

Only values 0 or 1.

---

# 22. Mutex

Mutual Exclusion Lock.

```text
lock()
Critical Section
unlock()
```

Characteristics:

* Only owner can unlock.
* Used only for mutual exclusion.

---

# 23. Semaphore vs Mutex

| Semaphore                           | Mutex                 |
| ----------------------------------- | --------------------- |
| Counting or Binary                  | Binary only           |
| Any process can signal              | Only owner unlocks    |
| Resource counting & synchronization | Mutual exclusion only |

---

# 24. Deadlock

Processes wait forever for resources held by each other.

Example:

```text
P1 waits for resource held by P2
P2 waits for resource held by P1
```

---

# 25. Deadlock Conditions (Necessary)

1. Mutual Exclusion
2. Hold and Wait
3. No Preemption
4. Circular Wait

All four must occur together.

---

# 26. Deadlock Prevention

Break at least one deadlock condition.

Examples:

* Resource preemption.
* Request all resources at once.

---

# 27. Deadlock Avoidance

OS grants resources only if system remains safe.

### Methods

* Resource Allocation Graph
* Banker's Algorithm
* Safe State Analysis

---

# Exam Quick Summary

### Fragmentation

* Internal → Wasted space inside allocated memory.
* External → Free memory scattered.

### Paging

* Page ↔ Frame mapping.
* Uses Page Table + TLB.
* Removes external fragmentation.

### Segmentation

* Segment + Offset addressing.
* Logical division of process.

### Virtual Memory

* Disk acts as RAM extension.

### Page Fault

* Page absent from RAM.

### Thrashing

* Excessive swapping.

### fork()

* Creates child process.

### exec()

* Replaces process image.

### wait()

* Collects child status.

### Semaphore

* Counter-based synchronization.

### Mutex

* Ownership-based lock.

### Deadlock

* Mutual Exclusion + Hold & Wait + No Preemption + Circular Wait.
