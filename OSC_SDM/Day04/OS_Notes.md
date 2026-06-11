# Operating System (OS) – Quick Revision Notes

## 1. What is an Operating System?
An Operating System (OS) is system software that acts as an interface between users/applications and computer hardware.

### Responsibilities
- Process Management
- Memory Management
- File Management
- Device Management
- Security
- CPU Scheduling

### Examples
- Windows
- Linux
- macOS

---

# 2. Evolution of Operating Systems

## Resident Monitor
- Earliest form of OS.
- Resides in memory.
- Loads and executes programs.
- Reports errors.

## Batch System
- Similar jobs are grouped into batches.
- Programs execute one after another.
- CPU remains idle during I/O operations.

## Multiprogramming
- Multiple programs loaded into RAM simultaneously.
- Improves CPU utilization.
- If one process waits for I/O, CPU executes another process.

### Degree of Multiprogramming
Number of programs loaded into memory at the same time.

---

# 3. CPU Bound vs I/O Bound

## CPU Bound Process
CPU Burst > I/O Burst

Examples:
- Video Rendering
- Scientific Computation

## I/O Bound Process
I/O Burst > CPU Burst

Examples:
- File Operations
- Database Queries

### Interview Point
A mix of CPU-bound and I/O-bound processes improves CPU utilization.

---

# 4. Schedulers

## Long-Term Scheduler (Job Scheduler)
- Selects jobs from disk.
- Loads jobs into memory.
- Controls degree of multiprogramming.

## Short-Term Scheduler (CPU Scheduler)
- Selects a process from the ready queue.
- Allocates CPU for execution.

---

# 5. Multitasking (Time Sharing)

CPU time is shared among multiple processes.

### Benefits
- Fast response time
- Multiple applications appear to run simultaneously

### Types

#### Process-Based Multitasking
Multiple independent processes execute concurrently.

#### Thread-Based Multitasking (Multithreading)
Multiple threads within the same process execute concurrently.

---

# 6. Multiprocessing

Using multiple CPUs or cores simultaneously.

### Advantages
- Higher throughput
- Faster execution
- Better performance

---

# 7. Multiprocessor Systems

## Asymmetric Multiprocessing (AMP)
- One processor acts as master.
- Master distributes work to others.

## Symmetric Multiprocessing (SMP)
- All processors are equal.
- Tasks scheduled independently.
- Modern systems use SMP.

---

# 8. Multiuser Systems

Multiple users can access the same system simultaneously.

### Examples
- UNIX
- Windows Server
- IBM Mainframe Systems

---

# 9. Desktop Systems

Designed for:
- User convenience
- Fast response

Examples:
- Windows
- Linux
- macOS

---

# 10. Handheld Systems

Used in:
- Smartphones
- Tablets
- PDAs

### Challenges
- Small screens
- Limited RAM
- Low-power processors
- Battery constraints

---

# 11. Real-Time Operating System (RTOS)

An OS where correctness depends on:
1. Correct result
2. Correct timing

### Features
- Fixed deadlines
- Very low interrupt latency

### Applications
- Medical Devices
- Robotics
- Aircraft Systems
- Industrial Automation

### Examples
- FreeRTOS
- VxWorks
- RTLinux

---

# 12. Interrupt Latency

Time between:
Interrupt Arrival → Interrupt Handling Start

RTOS requires very small interrupt latency.

---

# 13. Distributed Systems

Multiple computers connected through a network.

### Advantages
- High Availability
- Fault Tolerance
- Scalability
- Load Balancing

### Cluster
A group of computers working together for a common task.

---

# 14. Thread Concept

Thread = Lightweight Process

### Characteristics
- Shares code, data, and heap with parent process.
- Has its own stack and execution context.
- Faster context switching.
- Faster communication than processes.

---

# 15. Process vs Thread

| Process | Thread |
|----------|---------|
| Heavyweight | Lightweight |
| Own memory space | Shares process memory |
| Slower context switch | Faster context switch |
| More resources | Fewer resources |
| Resource container | Unit of execution |

### Remember
Process = Resource Holder
Thread = CPU Execution Unit

---

# 16. Main Thread

- Created automatically when a process starts.
- Executes the entry point (main function).
- Uses process stack.
- Terminating the main thread terminates the process.

---

# 17. Process Life Cycle

New → Ready → Running → Waiting → Ready → Running → Terminated

### States

#### New
Process is created.

#### Ready
Waiting for CPU.

#### Running
Executing on CPU.

#### Waiting (Blocked)
Waiting for I/O completion.

#### Terminated
Execution completed.

---

# 18. Scheduling Types

## Non-Preemptive Scheduling
CPU released voluntarily.

Examples:
- FCFS
- SJF

## Preemptive Scheduling
CPU can be taken forcibly.

Examples:
- Round Robin
- SRTF
- Priority Scheduling

---

# 19. Scheduling Criteria

## CPU Utilization
Goal: Maximum

## Throughput
Goal: Maximum

Number of processes completed per unit time.

## Waiting Time
Goal: Minimum

Time spent in ready queue.

## Turnaround Time
Goal: Minimum

Turnaround Time =
CPU Burst + I/O Burst + Waiting Time

## Response Time
Goal: Minimum

Time from arrival to first CPU allocation.

---

# 20. Scheduling Algorithms

## FCFS (First Come First Serve)

### Characteristics
- Non-preemptive
- First arrival executes first

### Drawback
Convoy Effect:
Large processes delay smaller processes.

---

## SJF (Shortest Job First)

### Characteristics
- Non-preemptive
- Shortest burst time executes first

### Advantage
Minimum average waiting time.

---

## SRTF (Shortest Remaining Time First)

### Characteristics
- Preemptive version of SJF
- Process with shortest remaining burst executes first

### Advantage
Minimum average waiting time.

---

## Priority Scheduling

### Characteristics
- Each process assigned a priority.
- Lower number = Higher priority.

### Problem
Starvation

### Solution
Aging

---

## Round Robin (RR)

### Characteristics
- Preemptive scheduling
- Fixed Time Quantum

### Advantages
- Fair scheduling
- Excellent response time
- Used in time-sharing systems

---

# 21. Starvation

A process waits indefinitely because higher-priority processes continuously receive CPU time.

### Solution
Aging:
Gradually increase process priority over time.

---

# 22. Quick Interview Revision

### Definitions
- Process = Program in execution
- Thread = Lightweight process
- CPU Scheduler = Selects next process for CPU
- Job Scheduler = Loads jobs into memory

### Important Formulas
- CPU Bound → CPU Burst > I/O Burst
- I/O Bound → I/O Burst > CPU Burst
- Turnaround Time = Arrival to Completion
- Response Time = Arrival to First CPU Allocation

### Most Important Scheduling Algorithms
1. FCFS
2. SJF
3. SRTF
4. Priority
5. Round Robin

### Most Asked Interview Questions
- Difference between Process and Thread
- CPU Bound vs I/O Bound
- Long-Term vs Short-Term Scheduler
- FCFS vs SJF vs Round Robin
- What is Starvation?
- What is Aging?
- What is RTOS?
- What is Multiprogramming?
- What is Multithreading?
