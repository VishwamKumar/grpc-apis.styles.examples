# 🧩 ToDoApp - gRPC API Examples (Layered Architecture)

This repository demonstrates multiple gRPC API implementations for a simple ToDo application using **.NET 9** and **layered architecture**. Each project showcases a different style or feature of gRPC communication.

---

# Author

## Vishwa Kumar
- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary architect of the ToDoApp, responsible for the architecture and implementation of these features.


## 📦 Included Projects

### 1. `ToDoApp.Data.Sqlite`
> Data Access Layer  
Implements Entity Framework Core using a local **SQLite** database. This layer contains the data model, `DbContext`, and the `ToDoItem` repository used by both gRPC APIs.

---

### 2. `ToDoApp.GrpcApi.Native`
> Pure gRPC Service (No JSON Transcoding)  
Implements gRPC endpoints defined in `.proto` files for managing ToDo items. Designed for internal or high-performance communication between microservices.

- ✅ High performance
- ❌ No Swagger / REST compatibility
- ✅ Supports tools like `grpcurl`, `Postman` (with .proto or reflection)
- 🚫 Not human-readable over HTTP (binary protocol)

---

### 3. `ToDoApp.GrpcApi.Transcoding`
> gRPC with REST-style JSON Transcoding  
Uses `Grpc.AspNetCore.GrpcJsonTranscoding` to expose the same gRPC service as a **RESTful JSON API**. Great for scenarios where external clients (e.g., frontends, mobile apps) need to use HTTP/JSON.

- ✅ gRPC and REST with single implementation
- ✅ Swagger/OpenAPI documentation available
- ✅ Usable in Postman and Swagger UI
- 📦 Slightly higher overhead due to transcoding

---

## ✅ Key Features

- Built on **.NET 9** using a layered architecture
- Shared EF Core Data Layer for both gRPC APIs
- Local SQLite DB for ease of testing and development
- Easy-to-run and test each service independently
- Can be extended to include auth, validation, and advanced patterns (e.g., CQRS)

---

## 🛠️ How to Run

Each project contains its own `.sln` file so you can run them independently from Visual Studio or the CLI.

To run a project:
```bash
cd ToDoApp.GrpcApi.Native   # or Transcoding
dotnet run

### Prerequisites
- [.NET SDK 9+](https://dotnet.microsoft.com)
- Visual Studio 2022 or VS Code
- EF Core tools (if working with migrations)

---

## 🔍 Goals
- Help developers understand different gRPC API implementation patterns.
- Enable experimentation and benchmarking.
- Provide a base for extending to Clean Architecture or CQRS in the future.

---

## 📌 Roadmap
- [ ] Add MediatR-based APIs
- [ ] Add Clean Architecture sample

---

## 📄 License
This project is licensed under the MIT License.
