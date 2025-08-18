# Sonali.API – ASP.NET Core 8 Web API (Clean Architecture)

## 📌 Overview

**Sonali.API** is an ASP.NET Core 8 Web API project following **Clean Architecture** principles.\
It separates concerns into distinct layers for maintainability, scalability, and testability.

- **Domain Layer** – Core business entities, DTOs, interfaces, and validation.
- **DomainService Layer** – Handles data retrieval with **ADO.NET** for optimized read operations (CQRS pattern).
- **Infrastructure.DAL Layer** – Manages data persistence (Insert/Update/Delete) using **Entity Framework Core**.
- **Infrastructure.Data Layer** – Contains EF Core `DbContext` and models (Database-First approach).
- **Utilities Layer** – Provides reusable helpers, extensions, and JWT handling.
- **API Layer** – Entry point, controllers, middlewares, services, and dependency injection.

This architecture ensures separation of concerns, CQRS pattern adoption, and flexible data access strategies.

---

## 🏗️ Project Structure

```
Sonali.API (Presentation Layer)
│── Controllers/        → API endpoints
│── Middlewares/        → Custom middlewares
│── Services/           → Application services
│── ServicesRegister/   → Dependency injection
│── appsettings.json    → Configuration
│── Program.cs          → Startup

Sonali.API.Domain (Domain Layer)
│── DTOs/               → Data Transfer Objects
│── Entities/           → Business entities
│── Interface/          → Abstractions
│── Validators/         → FluentValidation & business rules

Sonali.API.DomainService (Application Layer - Query side)
│── Base/               → Base services
│── DataService/        → ADO.NET-based query services
│── Interface/          → Service contracts
│── Repository/         → Read repositories

Sonali.API.Infrastructure.DAL (Infrastructure Layer - Command side)
│── Base/               → EF Core base classes
│── Repository/         → EF Core repositories for Insert/Update/Delete

Sonali.API.Infrastructure.Data (Database Layer)
│── Data/               → EF DbContext (Db-First)
│── Models/             → EF models

Sonali.API.Utilities (Shared Utilities)
│── EntityExtensions/   → Entity extension methods
│── Extensions/         → General extension methods
│── Helper/             → Utility/helper classes
│── Common.cs           → Shared constants & methods
│── JWTSettings.cs      → JWT configuration
```

---

## ⚙️ Technology Stack

- **.NET 8 (ASP.NET Core Web API)**
- **Entity Framework Core** (Database-First for persistence)
- **ADO.NET** (Optimized query handling for reads)
- **FluentValidation** (Validation layer)
- **JWT Authentication** (Secure API access)
- **Clean Architecture + CQRS pattern**

---

## 🚀 Getting Started

### 1️⃣ Prerequisites

- .NET 8 SDK
- SQL Server (or any configured DB)
- Visual Studio 2022 / VS Code

### 2️⃣ Setup & Run

```bash
# Clone repository
git clone <your-repo-url>
cd Sonali.API

# Restore dependencies
dotnet restore

# Build solution
dotnet build

# Run API
dotnet run --project Sonali.API
```

API will be available at:\
👉 `https://localhost:5001/swagger` (Swagger UI)

---

## 🔑 Authentication

**Uses JWT (JSON Web Tokens).**

- Configure `JWTSettings.cs` and `appsettings.json`.
- Pass JWT token via `Authorization: Bearer <token>` header.

---

## 📂 CQRS Implementation

- **Queries (Reads)** → DomainService (ADO.NET for performance)
- **Commands (Write operations)** → Infrastructure.DAL (EF Core for persistence)

This ensures optimized reads and maintainable writes.

---

## 🛠️ Utilities

- **Entity & General Extensions** → Reusable extension methods
- **Helper Classes** → Common functions
- **JWT Helpers** → Token generation & validation

---

## ✅ Advantages

- Clear separation of concerns
- CQRS support (Read/Write segregation)
- Easy to extend and maintain
- Testable and modular

---

## 📌 Future Improvements

- Add **Unit of Work** pattern for EF Core
- Add **MediatR** for CQRS command/query handling
- Introduce **Unit Tests / Integration Tests**
- Containerize with **Docker & Kubernetes**

---

## 📝 Example API Usage

### 1️⃣ Login

**POST** `/api/auth/login`

Request:

```json
{
  "UserName": "admin",
  "Password": "password123"
}
```

Response:

```json
{
  "token": "<jwt-token>",
  "expires": "2025-08-18T18:00:00Z"
}
```

**Use token in subsequent requests:**

```
Authorization: Bearer <jwt-token>
```

---

### 2️⃣ CRUD Sample (Voucher)

#### Create Voucher

**POST** `/api/vouchers`

```json
{
  "voucherNo": "V123",
  "userId": 1,
  "amount": 500.00,
  "date": "2025-08-18"
}
```

#### Read Vouchers

**GET** `/api/vouchers?userId=1&voucherNo=V123`

#### Update Voucher

**PUT** `/api/vouchers/1`

```json
{
  "amount": 600.00
}
```

#### Delete Voucher

**DELETE** `/api/vouchers/1`

---

This README provides a complete overview and onboarding guide for new developers.

