
# Day 12 – ASP.NET Core MVC Filters & Request Pipeline 🚀

## Complete Interview Notes + Quick Revision Guide

---

# Table of Contents

1. What are Filters?
2. Why Filters are Needed
3. Types of Filters
4. Filter Execution Order
5. Authorization Filters
6. Resource Filters
7. Action Filters
8. Result Filters
9. Exception Filters
10. Endpoint Filters
11. Request Pipeline
12. Middleware vs Filters
13. Attributes in C#
14. AttributeUsage Explained
15. Real-World Examples
16. Mind Map
17. Quick Revision Notes

---

# What are Filters?

Filters are components in ASP.NET Core MVC that allow code to execute before or after specific stages of request processing.

They help implement cross-cutting concerns such as:

- Authorization
- Logging
- Caching
- Error Handling
- Validation
- Response Modification

---

# Why Filters?

Without Filters:

```text
Controller A → Logging
Controller B → Logging
Controller C → Logging
```

With Filters:

```text
Global Filter
      ↓
All Controllers
```

Benefits:
- Reusable code
- Centralized logic
- Better maintainability
- Cleaner controllers

---

# Types of Filters

| Filter Type | Purpose |
|------------|---------|
| Authorization Filter | Security & access control |
| Resource Filter | Caching & performance |
| Action Filter | Before/after action execution |
| Result Filter | Before/after result execution |
| Exception Filter | Error handling |
| Endpoint Filter | Minimal APIs |

---

# Filter Execution Order

```text
Request
   ↓
Authorization Filter
   ↓
Resource Filter
   ↓
Action Filter
   ↓
Controller Action
   ↓
Result Filter
   ↓
Response
```

If an exception occurs:

```text
Exception Filter
      ↓
Error Response
```

---

# Authorization Filter

## Purpose

Checks whether a user is allowed to access a resource.

### Real-World Example

```text
Bank Website
      ↓
User Not Logged In
      ↓
Access Denied
```

---

# Resource Filter

## Purpose

Runs before model binding.

Used for:

- Caching
- Performance optimization

### Example

```text
Load Cached Product Data
Instead of Database Query
```

---

# Action Filter

## Purpose

Executes before and after an action method.

### Syntax

```csharp
public class CustomActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}
```

### Use Cases

- Logging
- Validation
- Security checks
- Performance monitoring

### Flow

```text
Before Action
      ↓
Action Executes
      ↓
After Action
```

---

# Result Filter

## Purpose

Executes before and after action results.

### Syntax

```csharp
public class CustomResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
    }
}
```

### Use Cases

- Response formatting
- Adding headers
- Auditing
- Logging

### Flow

```text
Controller Result
      ↓
Result Filter
      ↓
Final Response
```

---

# Exception Filter

## Purpose

Handles unhandled exceptions globally.

### Flow

```text
Exception
      ↓
Exception Filter
      ↓
Friendly Error Page
```

### Example

```text
Database Connection Failed
      ↓
Show Custom Error Page
```

---

# Endpoint Filters

Used with Minimal APIs.

```text
Request
      ↓
Endpoint Filter
      ↓
Endpoint Logic
```

---

# What is the Request Pipeline?

The ASP.NET Core Request Pipeline is the ordered flow of middleware that processes every HTTP request.

---

# Request Pipeline Flow

```text
Incoming Request
        ↓
Exception Middleware
        ↓
HTTPS Redirection
        ↓
Static Files
        ↓
Routing
        ↓
Authentication
        ↓
Authorization
        ↓
MVC Filters
        ↓
Controller Action
        ↓
Result
        ↓
Response
```

---

# Middleware vs Filters

| Middleware | Filters |
|------------|---------|
| Entire application | MVC only |
| Runs before MVC | Runs inside MVC |
| Global processing | Controller/action processing |

---

# What are Attributes in C#?

Attributes provide metadata about code elements.

Example:

```csharp
[Obsolete]
public void Test()
{
}
```

---

# AttributeUsage Explained

```csharp
[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Method,
    Inherited = true)]
```

### Common Targets

| Target | Usage |
|----------|---------|
| Class | Classes |
| Method | Methods |
| Property | Properties |
| Field | Variables |
| Enum | Enumerations |
| Struct | Structures |
| Constructor | Constructors |
| All | Anywhere |

---

# Custom Attribute Example

```csharp
[AttributeUsage(AttributeTargets.Method)]
public class LogAttribute : Attribute
{
}
```

---

# Real-World MVC Filter Examples

| Scenario | Filter |
|-----------|----------|
| Login Check | Authorization Filter |
| Product Cache | Resource Filter |
| Request Logging | Action Filter |
| Response Formatting | Result Filter |
| Global Error Handling | Exception Filter |

---

# MVC Filters Mind Map 🧠

```text
MVC Filters
│
├── Authorization
│      └── Security
│
├── Resource
│      └── Caching
│
├── Action
│      ├── Logging
│      └── Validation
│
├── Result
│      ├── Headers
│      └── Response Formatting
│
├── Exception
│      └── Error Handling
│
└── Endpoint
       └── Minimal APIs
```

---

# Quick Revision Notes ⚡

| Concept | Meaning |
|----------|----------|
| Filter | Executes around MVC pipeline |
| Authorization | Access control |
| Resource | Performance optimization |
| Action | Before & after action |
| Result | Before & after response |
| Exception | Error handling |
| Endpoint | Minimal APIs |
| Attribute | Metadata |
| Middleware | Global request pipeline |

---

# One-Line Memory Tricks

```text
Authorization → Who can enter?
Resource → Use cache?
Action → Around action execution
Result → Around response generation
Exception → Handle errors
Attribute → Metadata
Middleware → Global pipeline
```

---

# Original Class Notes

```md
## Day-12_Concepts_Of_MVC_Filters_&_There_Implementation

## What are the Filters In .NET?
=> In .NET (specifically ASP.NET Core and MVC), filters are components that allow you to run code before or after specific stages in the request processing pipeline. They are mainly used for cross-cutting concerns like authorization, caching, logging, error handling, and response modification.

🔑 What Filters Do

Run at different stages of the request pipeline (before/after actions, results, or exceptions).
Avoid code duplication by centralizing logic such as authentication, logging, or error handling.
Can be global, per-controller, or per-action, giving flexibility in scope.

🧩 Types of Filters in .NET

| Filter Type| Execution Stage | Purpose |
| --- | --- | --- |
| Authorization Filters | Run first | Check if the user is authorized; short-circuit if not. |
|Resource Filters| After authorization, before model binding | Useful for caching or performance optimizations. |
|Action Filters| Before & after action methods | Modify input arguments or action results. |
|Exception Filters| When unhandled exceptions occur | Apply global error handling policies. |
|Result Filters| Before & after action results | Surround view/formatter execution, e.g., modifying responses. |
|Endpoint Filters| Around endpoint execution | Similar to action filters but work with minimal APIs and route handlers.|


⚙️ Implementation Notes

Filters can be synchronous or asynchronous.
Implemented via interfaces like IAuthorizationFilter, IActionFilter, IExceptionFilter, etc.

Example of an Action Filter:

public class SBFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Code before action executes
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Code after action executes
    }
}


Key Use Cases

Authorization → Restrict access to certain users.
Caching → Improve performance by short-circuiting requests.
Logging → Track request/response details.
Error Handling → Centralize exception management.
Response Modification → Adjust output before sending to client.


## What is the Request Pipeline?
=> In ASP.NET Core, the pipeline is the ordered flow of middleware components that process every HTTP request and response. Each middleware can inspect, modify, or short-circuit the request, and the flow determines how the application handles authentication, routing, static files, errors, and more.

The pipeline is a sequence of middleware components.

Each middleware:
    Runs in order of registration.
    Can perform work before and after the next middleware.
    Can stop the flow (terminal middleware).
    
Configured in Program.cs (or Startup.cs in older versions).

| Stage | Purpose |
| --- | --- |
| Request Entry | Incoming HTTP request enters the pipeline. |
| Exception Handling| Captures and logs unhandled exceptions early. |
| Security Middleware| Enforces HTTPS (HSTS, redirection). |
| Static Files | Serves CSS, JS, images directly without further processing. |
| Routing | Maps request to controllers, Razor Pages, or endpoints. |
| CORS | Handles cross-origin requests. |
| Authentication | Validates user identity. |
| Authorization | Ensures user has permission to access resource. |
| Endpoint Execution | Executes controller action, Razor Page, or minimal API. |
| Response Generation | Builds and sends HTTP response back to client. |

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseExceptionHandler("/Home/Error");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoutes(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


## What is the main purpose of an result filter?
=> A **Result Filter** in ASP.NET Core (part of the MVC filter pipeline) is designed to run **before and after the execution of an action result**. Its main purpose is to let you **intercept and modify the response** that is about to be sent to the client, or perform logic around the rendering of views, JSON, or other result types.

---

## 🎯 Main Purpose of Result Filters
- **Pre-processing before result execution** → e.g., adding headers, wrapping data, or adjusting response formatting.
- **Post-processing after result execution** → e.g., logging, auditing, or modifying the final response before it leaves the server.
- **Cross-cutting concerns** → centralizing logic that applies to multiple actions without duplicating code.

---

## 🧩 How They Work
- Implemented via `IResultFilter` or `IAsyncResultFilter`.
- Two key methods:
  - `OnResultExecuting(ResultExecutingContext context)` → runs **before** the result executes.
  - `OnResultExecuted(ResultExecutedContext context)` → runs **after** the result executes.

Example:

```csharp
public class CustomResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        // Code before result executes
        context.HttpContext.Response.Headers.Add("X-Custom-Header", "MyValue");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        // Code after result executes
        // e.g., logging response status
    }
}
```

---

## 📌 Common Use Cases
- **Response headers** → Inject custom headers for security or metadata.
- **Response wrapping** → Standardize API responses (e.g., wrap all results in a common format).
- **Logging** → Capture details about the final response.
- **Caching** → Apply caching logic around results.
- **Auditing** → Track what was returned to clients.

---

✅ In short: **Result Filters are about controlling and shaping the *final output* of an action before it reaches the client.**  

## What is the main purpose of an action filter?
=> An **Action Filter** in ASP.NET Core is used to run code **before and after an action method executes**. Its main purpose is to let you **intercept the execution of controller actions**, giving you control over inputs, outputs, and additional logic around the action itself.

---

## 🎯 Main Purpose of Action Filters
- **Pre-processing before the action runs** → validate input, modify parameters, or enforce rules.
- **Post-processing after the action runs** → inspect or modify the action result, log data, or trigger side effects.
- **Cross-cutting concerns** → centralize logic that applies to multiple actions without duplicating code.

---

## 🧩 How They Work
- Implemented via `IActionFilter` or `IAsyncActionFilter`.
- Two key methods:
  - `OnActionExecuting(ActionExecutingContext context)` → runs **before** the action method.
  - `OnActionExecuted(ActionExecutedContext context)` → runs **after** the action method.

Example:

```csharp
public class CustomActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Code before action executes
        // Example: validate request data
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Code after action executes
        // Example: log execution time
    }
}
```

---

## 📌 Common Use Cases
- **Validation** → enforce rules before the action runs.
- **Logging** → track request/response details around actions.
- **Performance monitoring** → measure execution time of actions.
- **Data modification** → adjust input parameters or results.
- **Security checks** → ensure certain conditions before running sensitive actions.

---

✅ In short: **Action Filters are about controlling and shaping the *execution of controller actions* themselves, not just the final output.**  


## what is attribute and where can we use it?
=> `[AttributeUsage(...)]` is itself an attribute that tells C# **where another custom attribute is allowed to be applied**.

Example:

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class MyAttribute : Attribute
{
}
```

This means `MyAttribute` can only be applied to **classes**.

---

## What is `AttributeTargets`?

`AttributeTargets` is an enum that specifies valid targets.

Some common values:

```csharp
AttributeTargets.Class
AttributeTargets.Method
AttributeTargets.Property
AttributeTargets.Field
AttributeTargets.Event
AttributeTargets.Interface
AttributeTargets.Enum
AttributeTargets.Struct
AttributeTargets.Constructor
AttributeTargets.Parameter
AttributeTargets.ReturnValue
AttributeTargets.Assembly
AttributeTargets.Module
AttributeTargets.Delegate
AttributeTargets.All
```

---

## Examples

### 1. Only Classes

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class InfoAttribute : Attribute
{
}

[Info]      // ✔ Valid
public class Employee
{
}
```

```csharp
[Info]      // ❌ Compile-time error
public void Display()
{
}
```

---

### 2. Only Methods

```csharp
[AttributeUsage(AttributeTargets.Method)]
public class LogAttribute : Attribute
{
}

public class Test
{
    [Log]    // ✔ Valid
    public void Save()
    {
    }
}
```

---

### 3. Classes and Methods

Use the bitwise OR operator (`|`):

```csharp
[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Method)]
public class AuditAttribute : Attribute
{
}
```

Now it can be used on both:

```csharp
[Audit]
public class Employee
{
    [Audit]
    public void Save()
    {
    }
}
```

---

### 4. Everywhere

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DemoAttribute : Attribute
{
}
```

Can be applied to classes, methods, properties, fields, etc.

---

## What does `Inherited = true` mean?

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class InfoAttribute : Attribute
{
}
```

```csharp
[Info]
public class Person
{
}

public class Employee : Person
{
}
```

Because `Inherited = true`, `Employee` is considered to have the `InfoAttribute` when accessed through reflection.

---

## Quick Interview Note

```csharp
[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Method,
    AllowMultiple = false,
    Inherited = true)]
```

* **AttributeTargets** → Where the attribute can be used.
* **AllowMultiple** → Can the same attribute be applied more than once?
* **Inherited** → Should derived classes inherit the attribute?

Think of `AttributeUsage` as the **rules/permissions** for your custom attribute. It controls whether that attribute can be placed on a class, method, property, field, parameter, assembly, or any combination of them.



```