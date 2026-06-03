# .NET Concurrency & Software Engineering Quick Notes

# 1. Threading

## Definition
A **Thread** is the smallest unit of execution inside a process.

> Threading is the technique of running multiple execution paths within an application.

## Why Threading?
- Improves responsiveness
- Enables background processing
- Supports concurrent operations

## Example
```csharp
Thread t = new Thread(MyMethod);
t.Start();
```

## Real-World Examples
- Web browser loading pages and images simultaneously
- Video streaming while loading comments
- Web APIs handling multiple requests

---

# 2. Multithreading

## Definition
**Multithreading** is the execution of multiple threads within a single process.

> Multiple threads work concurrently to perform different tasks.

## Benefits
- Better performance
- Improved responsiveness
- Better CPU utilization

## Example
```csharp
Thread t1 = new Thread(PrintNumbers);
Thread t2 = new Thread(PrintLetters);

t1.Start();
t2.Start();
```

## Real-World Example
```text
Application
├── Thread 1 → Download File
├── Thread 2 → Play Music
└── Thread 3 → Update UI
```

---

# 3. Task

## Definition
A **Task** represents an asynchronous operation.

> A Task is a higher-level abstraction over threads.

## Why Use Tasks?
- Easier than managing threads
- Uses Thread Pool internally
- Better performance and scalability

## Example
```csharp
Task.Run(() =>
{
    Console.WriteLine("Task Running");
});
```

## Task with Return Value
```csharp
Task<int> task = Task.Run(() => 100);
```

## Async/Await
```csharp
public async Task GetData()
{
    await Task.Delay(2000);
}
```

## Thread vs Task

| Thread | Task |
|----------|----------|
| Low-level | High-level |
| Manual management | Managed by .NET |
| More resources | Less resources |
| Older approach | Modern approach |

---

# 4. Parallel Programming

## Definition
Parallel Programming executes multiple operations simultaneously using multiple CPU cores.

> Goal: Complete work faster by dividing it among available processors.

## Example
```csharp
Parallel.For(1, 10, i =>
{
    Console.WriteLine(i);
});
```

## Parallel.ForEach
```csharp
Parallel.ForEach(items, item =>
{
    Process(item);
});
```

## Use Cases
- Data processing
- Scientific calculations
- Machine learning
- Image processing
- Financial analysis

## Parallel vs Async

| Parallel | Async/Await |
|-----------|------------|
| CPU-bound work | I/O-bound work |
| Multiple cores | Non-blocking execution |
| Performance improvement | Responsiveness improvement |

---

# 5. Deadlock

## Definition
A **Deadlock** occurs when two or more threads wait indefinitely for resources held by each other.

> No thread can proceed, causing the application to hang.

## Example Scenario

```text
Thread 1 holds Lock A
Thread 1 waits for Lock B

Thread 2 holds Lock B
Thread 2 waits for Lock A
```

Result:

```text
Deadlock
```

## Causes
1. Mutual Exclusion
2. Hold and Wait
3. No Preemption
4. Circular Wait

## Prevention
- Acquire locks in the same order
- Minimize lock duration
- Use timeout mechanisms
- Avoid nested locks

---

# 6. Work-Stealing Algorithm

## Definition
The **Work-Stealing Algorithm** is used by the .NET Thread Pool and Task Parallel Library (TPL).

> Idle threads steal tasks from busy threads to balance workload.

## Example

Before:

```text
Thread 1 → 10 Tasks
Thread 2 → 0 Tasks
```

After Work-Stealing:

```text
Thread 1 → 5 Tasks
Thread 2 → 5 Tasks
```

## Benefits
- Better CPU utilization
- Automatic load balancing
- Improved performance
- Better scalability

---

# 7. Proof of Concept (PoC)

## Definition
A **Proof of Concept (PoC)** is a small implementation created to verify that an idea or technology is technically feasible.

> PoC answers: "Can this solution actually work?"

## Purpose
- Validate feasibility
- Reduce project risk
- Identify technical challenges
- Estimate effort and cost

## Example

### E-Voting Blockchain Project PoC

```text
User Vote
    ↓
Smart Contract
    ↓
Store Vote on Blockchain
```

If successful, proceed with full development.

---

# Quick Interview Answers

## What is Threading?
Threading is the technique of running multiple execution paths within an application.

## What is Multithreading?
Multithreading is the concurrent execution of multiple threads within a single process.

## What is a Task?
A Task is a .NET object that represents an asynchronous operation.

## What is Parallel Programming?
Parallel Programming executes multiple operations simultaneously using multiple CPU cores.

## What is Deadlock?
Deadlock is a situation where threads wait indefinitely for resources held by each other.

## What is Work-Stealing?
Work-Stealing allows idle threads to take tasks from busy threads to improve load balancing.

## What is a PoC?
A Proof of Concept is a small implementation used to verify the feasibility of an idea or technology.

---

# Process → Thread → Task → Parallel

```text
Process
│
├── Thread
│
├── Multiple Threads (Multithreading)
│
├── Tasks (Async Operations)
│
└── Parallel Execution
     ├── Core 1
     ├── Core 2
     └── Core 3
```

### Key Takeaway

- Process = Running Application
- Thread = Execution Unit
- Multithreading = Multiple Threads
- Task = Asynchronous Work
- Parallel Programming = Multiple Cores Working Together
- Deadlock = Threads Waiting Forever
- Work-Stealing = Load Balancing Technique
- PoC = Feasibility Validation
