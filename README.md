# GeoShapes — Geometric Shapes Calculator

A C# console application for managing a collection of geometric shapes, calculating their area and perimeter, and rendering a visual ASCII representation of each shape.

Built as a learning exercise to practice Object-Oriented Programming principles and Class Library architecture in .NET.

---

## Features

- Add and remove geometric shapes (Square, Rectangle) to a collection
- Calculate **area** and **perimeter** for each shape
- **ASCII rendering** of each shape in the console
- Input validation with descriptive error messages
- Interactive console menu navigation

---

## Concepts Applied

- **Object-Oriented Programming:** Inheritance and polymorphism through a base `Shape` class
- **Class Library (DLL):** Geometry logic (`GeoLib`) is separated from the UI layer (`GeoUI`) and compiled as a reusable `.dll`
- **Exception Handling:** Invalid inputs are caught and communicated clearly to the user
- **Separation of Concerns:** Business logic and user interface live in independent projects

---

## Project Structure

```
GeoShapes/
│
├── GeoLib/                  # Class Library (compiled as .dll)
│   ├── Shape.cs             # Abstract base class
│   ├── Square.cs            # Inherits from Shape
│   └── Rectangle.cs        # Inherits from Shape
│
└── GeoUI/                   # Console Application
    ├── Program.cs           # Entry point
    ├── AddMenu.cs           # Menu for adding shapes
    └── ListMenu.cs          # Menu for listing and managing shapes
```

---

## How to Run

**Requirements:** .NET SDK 6.0 or later

```bash
# Clone the repository
git clone https://github.com/your-username/geoshapes.git
cd geoshapes

# Build and run
dotnet run --project GeoUI
```

---

## Demo

```
FORMAS GEOMETRICAS
==================

1- Agregar Forma
2- Listar Formas
0- Salir
```

After adding a Rectangle (base: 5, height: 3):

```
Area: 15
Perimetro: 16

. . . . . . . . . 
.                 . 
.                 . 
.                 . 
. . . . . . . . . 
```

---

## Technologies

- Language: **C#**
- Framework: **.NET 6**
- Architecture: **Multi-project solution (Class Library + Console App)**

---

## What I Learned

- Designing a class hierarchy using abstract base classes and virtual methods
- Packaging reusable logic as a Class Library (`.dll`) separate from the executable
- Handling user input robustly with validation and exception handling
- Structuring a multi-project .NET solution
