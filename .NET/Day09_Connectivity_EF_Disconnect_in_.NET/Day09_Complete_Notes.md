
# DAY 09 – Enterprise Architecture & Entity Framework 🚀

## Complete Beginner-Friendly C# & .NET Notes

---

# Topics Covered

- Enterprise Applications
- Layered Architecture
- Entity
- Entity Framework
- Connected Architecture
- Disconnected Architecture
- DataSet
- ADO.NET Flow
- Mind Maps
- Quick Revision Notes

---

# 1. What is Enterprise Application?

Enterprise Applications are large-scale business software systems.

---

# Real-World Examples

| Company | Application |
|---|---|
| Amazon | E-commerce |
| Bank | Banking System |
| Hospital | Hospital Management |
| Zomato | Food Delivery |

---

# Enterprise Flow

```text
User
  ↓
Frontend
  ↓
Business Logic
  ↓
Database
```

---

# 2. Layered Architecture

## What is Layered Architecture?

Application is divided into layers.

Each layer has separate responsibility.

---

# Why Use Layers?

| Benefit | Meaning |
|---|---|
| Maintainability | Easier updates |
| Scalability | Easy growth |
| Testability | Easier testing |
| Reusability | Reuse code |

---

# 3-Layer Architecture

```text
Presentation Layer
        ↓
Business Logic Layer
        ↓
Data Access Layer
```

---

# Presentation Layer

Handles:
- User input
- Output display

Examples:
- ASP.NET
- Blazor
- MAUI

---

# Business Logic Layer

Contains:
- Validation
- Rules
- Calculations

---

# Data Access Layer

Communicates with database.

Tools:
- ADO.NET
- EF Core
- Dapper

---

# 3. What is Entity?

Entity represents real-world object in software.

---

# Examples

| Real World | Entity |
|---|---|
| Student | Student Class |
| Product | Product Entity |
| Employee | Employee Model |

---

# Entity Syntax

```csharp
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

---

# Entity Flow

```text
Real Object
    ↓
C# Entity Class
    ↓
Database Table
```

---

# 4. What is Entity Framework?

Entity Framework is Microsoft's ORM.

ORM = Object Relational Mapper

---

# Working Flow

```text
C# Object
    ↓
Entity Framework
    ↓
SQL Query Generated
    ↓
Database
```

---

# Benefits

| Benefit | Meaning |
|---|---|
| Less SQL | Use C# instead |
| Faster Development | Auto mapping |
| Easy CRUD | Simplified DB operations |

---

# Real-World Example

```text
Product Object
    ↓
EF Core
    ↓
INSERT INTO Products
```

---

# 5. Connected Architecture

Application stays connected with DB.

---

# Flow

```text
Application
    ↓
Open Connection
    ↓
Execute Query
    ↓
Read Data
    ↓
Close Connection
```

---

# Components

- SqlConnection
- SqlCommand
- SqlDataReader

---

# Real-World Example

```text
ATM Live Transaction
```

---

# 6. Disconnected Architecture

Connection closes after data copied into memory.

---

# Flow

```text
Database
    ↓
DataAdapter
    ↓
DataSet
    ↓
Connection Closed
```

---

# Benefits

- Better scalability
- Offline processing
- Less server load

---

# Real-World Example

```text
Shopping App Product Cache
```

---

# 7. What is DataSet?

DataSet is in-memory mini database.

Stores:
- Tables
- Rows
- Relations

---

# Syntax

```csharp
DataSet ds = new DataSet();
```

---

# DataSet Flow

```text
Database
    ↓
SqlConnection
    ↓
SqlDataAdapter
    ↓
DataSet
    ↓
Offline Work
```

---

# Important Components

| Component | Purpose |
|---|---|
| SqlConnection | DB Connection |
| SqlDataAdapter | Bridge |
| DataSet | Memory storage |
| SqlCommandBuilder | Auto SQL generation |

---

# Syntax Example

```csharp
DataSet ds = new DataSet();

SqlConnection conn =
    new SqlConnection(connectionString);

SqlDataAdapter da =
    new SqlDataAdapter(
        "SELECT * FROM Emp", conn);

da.Fill(ds, "Emp");
```

---

# 8. Mind Map 🧠

```text
Enterprise App
│
├── Layers
│     ├── UI
│     ├── BLL
│     └── DAL
│
├── Data Access
│     ├── ADO.NET
│     ├── EF Core
│     └── Dapper
│
├── Architectures
│     ├── Connected
│     └── Disconnected
│
└── Storage
      ├── DataSet
      └── DataTable
```

---

# 9. Quick Revision Notes ⚡

| Concept | Meaning |
|---|---|
| Enterprise App | Large business software |
| BLL | Business rules |
| DAL | Database communication |
| Entity | Real-world object |
| EF Core | ORM tool |
| Connected | Live DB communication |
| Disconnected | Offline processing |
| DataSet | In-memory database |

---

# One-Line Memory Tricks 🧠

```text
Entity → Real-world object
EF Core → Object ↔ Table mapper
BLL → Brain of application
DAL → DB communication
DataSet → Offline DB copy
Connected → Live DB
Disconnected → Offline DB
```

---

# Original Uploaded Notes

```md
### DAY 09 Concepts of C# & .NET

## What is layers of code?
=> In C#, "layers of code" refers to Layered Architecture (often called N-Tier Architecture), a design pattern that organizes an application into distinct logical sections, each with a specific responsibility. This separation ensures that changing one part of the app (like switching a database) doesn't break the rest (like the user interface).

***Standard 3-Layer Architecture***

**Most C# applications are built using three primary layers:

1) Presentation Layer (UI): The "face" of the application where users interact with the software.
            Examples: ASP.NET Core Web Apps, Blazor, or MAUI for mobile.
            Responsibility: Displays data and handles user inputs.

2) Business Logic Layer (BLL): The "brain" of the application.
            Responsibility: Performs logical calculations, validates data, and enforces business rules before data is saved or displayed.

3) Data Access Layer (DAL): The interface for data storage.
            Tools: Often uses ORMs like Entity Framework Core or Dapper.
            Responsibility: Handles communication with the database (SQL, NoSQL) or external APIs to fetch and save data.

**Modern Evolution: Clean Architecture
In more complex C# projects, developers often use Clean Architecture, which further breaks down these layers to minimize dependencies:

1) Domain Layer: The core containing basic entities and business rules with zero outside dependencies.

2) Application Layer: Orchestrates "use cases" and coordinates how data flows between the domain and outside world.

3) Infrastructure Layer: Contains the actual implementations for external concerns like sending emails, logging, or database configurations.

**Why Use Layers?

Maintainability: Easier to debug and update because logic is isolated in specific folders or projects.
Reusability: You can use the same Business and Data layers for both a website and a mobile app.
Testability: Since layers are separate, you can write unit tests for your business logic without needing a real database.
Scalability: Each layer can be optimized or scaled independently as the application grows.


## What is DataSet?
=> 
***Syntax***
 DataSet ds = new DataSet();
 Creates an empty, in-memory warehouse to hold your data tables.
 
 SqlConnection conn = new SqlConnection(...);
 Sets up a bridge connection to your local SQL database named KDACDB.
 
 SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Emp", conn);
 Creates a shuttle (da) that knows how to fetch all rows from the Emp table using the bridge.
 
 da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
 Tells the shuttle to copy the table layout and the primary key rules from the database.
 
 SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
 Attaches an automatic programmer to the shuttle to write INSERT, UPDATE, and DELETE commands for you later.
 
 da.Fill(ds, "Emp");
 Opens the bridge, runs the query, creates a table named Emp inside your warehouse (ds), fills it with data, and closes the bridge.

 [Database: KDACDB] 
       │
       ▼ (1. Bridge opens via conn)
[SqlDataAdapter] ──(2. Copies layout & Primary Key)──► [SqlCommandBuilder]
       │                                                    │
       ▼ (3. Fetches rows from 'Emp' table)                 │ (4. Prepares automatic SQL)
[DataSet (ds)] <────────────────────────────────────────────┘
```

---

# Tags

`#csharp` `#dotnet` `#entityframework` `#ado.net`
