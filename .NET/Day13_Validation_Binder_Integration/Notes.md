# ASP.NET Core Quick Notes

# 1. HTTP Verbs (HTTP Methods)

HTTP verbs tell the server what action should be performed on a resource.

| HTTP Verb | Purpose | CRUD Operation | SQL Equivalent |
|------------|----------|---------------|----------------|
| GET | Retrieve data | Read | SELECT |
| POST | Create new data | Create | INSERT |
| PUT | Replace existing data completely | Update | UPDATE (Full) |
| PATCH | Update specific fields | Update | UPDATE (Partial) |
| DELETE | Remove data | Delete | DELETE |

## REST API Examples

```http
GET    /api/users
GET    /api/users/1

POST   /api/users

PUT    /api/users/1

PATCH  /api/users/1

DELETE /api/users/1
```

### Interview Point
HTTP verbs are methods used in HTTP requests to define the action that should be performed on a resource.

---

# 2. Model Validation

Model Validation ensures incoming data follows business rules before processing or storing it.

## Why It Is Needed

- Prevent invalid data from entering the database.
- Enforce business rules.
- Improve application security.
- Client-side validation can be bypassed.

## Example

```csharp
public class User
{
    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Range(18, 60)]
    public int Age { get; set; }
}
```

## Validation Check

```csharp
[HttpPost]
public IActionResult Create(User user)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    return Ok();
}
```

## Common Validation Attributes

| Attribute | Purpose |
|------------|----------|
| [Required] | Field cannot be empty |
| [StringLength] | Restricts length |
| [Range] | Restricts numeric values |
| [EmailAddress] | Validates email |
| [Phone] | Validates phone |
| [Url] | Validates URL |
| [RegularExpression] | Custom validation pattern |

### Flow

```text
Request
   ↓
Model Binding
   ↓
Model Validation
   ↓
Controller Action
```

---

# 3. Model Binding

Model Binding automatically converts HTTP request data into C# objects or method parameters.

## Sources Used by Model Binder

- Route Values
- Query String
- Form Data
- Request Body (JSON)

## Example

```csharp
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

[HttpPost]
public IActionResult Create(User user)
{
    return Ok();
}
```

The framework automatically fills the `user` object.

## Binding Attributes

### From Route

```csharp
public IActionResult Get([FromRoute] int id)
{
}
```

### From Query

```csharp
public IActionResult Search([FromQuery] string name)
{
}
```

### From Body

```csharp
public IActionResult Create([FromBody] User user)
{
}
```

### From Form

```csharp
public IActionResult Upload([FromForm] User user)
{
}
```

## Model Binding vs Model Validation

| Model Binding | Model Validation |
|--------------|------------------|
| Creates object from request data | Validates data |
| Runs first | Runs after binding |
| Converts data | Checks correctness |

---

# 4. Layout Page (Master Page)

A Layout Page contains common UI elements shared across multiple pages.

Examples:

- Header
- Footer
- Navigation Menu
- Sidebar

## Benefits

- Code Reusability
- Consistent UI
- Easy Maintenance
- Reduced Duplication

## Layout Example

### _Layout.cshtml

```html
<!DOCTYPE html>
<html>
<body>

<header>
    My Website
</header>

@RenderBody()

<footer>
    Copyright 2026
</footer>

</body>
</html>
```

### Home.cshtml

```html
<h1>Home Page</h1>
```

## Important Methods

### RenderBody()

Displays the content of the child page.

```csharp
@RenderBody()
```

### RenderSection()

Used for page-specific content.

```csharp
@RenderSection("Scripts", required: false)
```

## Location

```text
Views
 └── Shared
      └── _Layout.cshtml
```

---

# 5. Web API

A Web API allows applications to communicate using HTTP.

## Real-World Flow

```text
Client
   ↓
Web API
   ↓
Database
```

## API Example

```csharp
[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok();
    }
}
```

## Typical Response

```json
{
  "id": 1,
  "name": "Kumar"
}
```

## Why Use Web APIs?

- Mobile Applications
- React Applications
- Angular Applications
- Third-party Integrations
- Microservices

## MVC vs Web API

| MVC | Web API |
|------|---------|
| Returns HTML | Returns JSON/XML |
| Used for UI Rendering | Used for Data Exchange |
| Razor Views | API Endpoints |

---

# 6. React Integration with ASP.NET Core

React acts as the Frontend and ASP.NET Core acts as the Backend.

## Architecture

```text
React Frontend
       ↓
HTTP Requests
       ↓
ASP.NET Core Web API
       ↓
Database
```

## React Example

```javascript
useEffect(() => {
    fetch("https://localhost:5001/api/users")
        .then(response => response.json())
        .then(data => setUsers(data));
}, []);
```

## ASP.NET Core API Example

```csharp
[HttpGet]
public IActionResult GetUsers()
{
    return Ok(new[]
    {
        new { Id = 1, Name = "Kumar" }
    });
}
```

## Data Flow

```text
React UI
   ↓
Fetch/Axios
   ↓
Web API
   ↓
Database
   ↓
JSON Response
   ↓
React State
   ↓
UI Update
```

## Important Concepts

### CORS

Allows React and ASP.NET Core running on different origins to communicate.

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
```

### Authentication

Typical flow:

```text
React Login
    ↓
Web API
    ↓
JWT Token
    ↓
Store Token
    ↓
Authenticated Requests
```

---

# Interview Revision (One-Liners)

## HTTP Verbs
Methods used to perform CRUD operations over HTTP.

## Model Validation
Checks whether incoming data satisfies predefined rules.

## Model Binding
Automatically maps request data to C# objects and parameters.

## Layout Page
Common template containing shared UI components.

## Web API
Interface that allows applications to communicate through HTTP.

## React Integration
React handles the UI, ASP.NET Core handles business logic and data access.
