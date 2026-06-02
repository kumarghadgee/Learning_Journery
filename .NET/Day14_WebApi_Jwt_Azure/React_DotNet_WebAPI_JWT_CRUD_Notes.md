# React + ASP.NET Core Web API + CRUD + JWT Authentication

# 1. Overview

A modern full-stack application commonly consists of:

- Frontend: React
- Backend: ASP.NET Core Web API
- Database: SQL Server
- Authentication: JWT (JSON Web Token)

Architecture:

```text
+---------+
| React   |
+----+----+
     |
     | HTTP Requests (Axios/Fetch)
     v
+-------------------+
| ASP.NET Core API  |
+---------+---------+
          |
          | Entity Framework Core
          v
+-------------------+
| SQL Server        |
+-------------------+
```

---

# 2. What is a Web API?

A Web API is a backend service that allows applications to communicate over HTTP.

Responsibilities:

- Receive requests
- Execute business logic
- Access database
- Return responses

Example:

```http
GET /api/employees
```

Response:

```json
[
  {
    "id": 1,
    "name": "Kumar",
    "salary": 50000
  }
]
```

---

# 3. HTTP Verbs

| Verb | Purpose |
|--------|---------|
| GET | Read Data |
| POST | Create Data |
| PUT | Update Data |
| DELETE | Delete Data |

---

# 4. CRUD Operations

CRUD stands for:

- Create
- Read
- Update
- Delete

Employee Table:

| Id | Name | Salary |
|----|------|--------|
| 1 | Kumar | 50000 |
| 2 | Rahul | 60000 |

---

# 5. CRUD Flow

## CREATE

```text
React Form
    |
    v
POST Request
    |
    v
Web API
    |
    v
Database
```

Endpoint:

```http
POST /api/employees
```

---

## READ

```text
React Page
    |
    v
GET Request
    |
    v
Web API
    |
    v
Database
    |
    v
Employee List
```

Endpoint:

```http
GET /api/employees
```

---

## UPDATE

```text
User Edit
    |
    v
PUT Request
    |
    v
Web API
    |
    v
Database Updated
```

Endpoint:

```http
PUT /api/employees/1
```

---

## DELETE

```text
User Delete
    |
    v
DELETE Request
    |
    v
Web API
    |
    v
Record Removed
```

Endpoint:

```http
DELETE /api/employees/1
```

---

# 6. React and Axios

Install Axios:

```bash
npm install axios
```

GET:

```javascript
axios.get("/api/employees");
```

POST:

```javascript
axios.post("/api/employees", data);
```

PUT:

```javascript
axios.put("/api/employees/1", data);
```

DELETE:

```javascript
axios.delete("/api/employees/1");
```

---

# 7. JWT Authentication

JWT = JSON Web Token

A JWT is a secure token used for authentication and authorization.

Instead of sending username and password on every request, the client sends a token.

---

# 8. JWT Structure

A JWT contains 3 parts:

```text
Header.Payload.Signature
```

Example:

```text
eyJhbGciOiJIUzI1Ni...
```

## Header

Contains algorithm information.

```json
{
  "alg": "HS256",
  "typ": "JWT"
}
```

## Payload

Contains claims.

```json
{
  "userId": 1,
  "name": "Kumar",
  "role": "Admin"
}
```

## Signature

Used to verify token integrity.

---

# 9. JWT Authentication Flow

```text
+---------+
| React   |
+----+----+
     |
     | Login Request
     v
+-------------------+
| ASP.NET Core API  |
+---------+---------+
          |
          | Validate Credentials
          v
     Generate JWT
          |
          v
     Return Token
          |
          v
+---------+
| React   |
+---------+
```

Store Token:

```javascript
localStorage.setItem("token", token);
```

---

# 10. JWT Authorization Flow

```text
React
  |
  | Authorization: Bearer Token
  v
JWT Middleware
  |
  +--> Validate Signature
  |
  +--> Validate Expiry
  |
  +--> Extract Claims
  |
  v
Controller
```

If valid:

```text
200 OK
```

If invalid:

```text
401 Unauthorized
```

---

# 11. Complete Application Flow

```text
User Opens React App
          |
          v
User Logs In
          |
          v
React Sends Credentials
          |
          v
ASP.NET Core API
          |
          v
Validate User
          |
          v
Generate JWT
          |
          v
Return Token
          |
          v
Store Token
          |
          v
User Performs CRUD Operations
          |
          v
Token Sent With Every Request
          |
          v
JWT Middleware Validates Token
          |
          v
Controller Executes
          |
          v
Database Updated / Read
          |
          v
Response Returned To React
```

---

# 12. Project Architecture

```text
Frontend
--------
React
Axios
React Router

Backend
-------
ASP.NET Core Web API
JWT Authentication
Entity Framework Core

Database
--------
SQL Server
```

---

# 13. Interview Answer

React provides the user interface. It communicates with an ASP.NET Core Web API using HTTP requests through Axios. The Web API contains business logic and uses Entity Framework Core to interact with SQL Server. CRUD operations are implemented using GET, POST, PUT, and DELETE endpoints. Authentication is handled using JWT, where a token is generated after login and sent in the Authorization header for every secured request.

---

# Quick Revision

```text
React
  |
Axios
  |
Web API
  |
Entity Framework Core
  |
SQL Server

Authentication:
Login -> JWT -> Bearer Token

CRUD:
GET    = Read
POST   = Create
PUT    = Update
DELETE = Delete
```
