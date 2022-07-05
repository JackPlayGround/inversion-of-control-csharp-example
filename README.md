# C\# Inversion of Control

A IoC practice. every commit gives the same output as the following:

```
> dotnet run
1. Pencil 1 - 100 - 200
2. Pencil 2 - 200 - 200
3. Pencil 3 - 300 - 200
4. Pencil 4 - 400 - 200
```

- **commit 1:** dirty, tightly coupled code
- **commit 2:** Implement IoC using Factory Pattern
- **commit 3:** Implement Dependency Inversion by creating abstraction
- **commit 4:** Implement Dependency Injection
- **commit 5:** Implement Dependency Injection using DI container