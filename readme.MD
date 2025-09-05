# Access Specifiers in C#

Access specifiers (or access modifiers) in C# define the visibility and accessibility of classes, methods, and other members. The main access specifiers are:

| Specifier    | Description                                                                 |
|--------------|-----------------------------------------------------------------------------|
| `public`     | Accessible from any other code.                                              |
| `private`    | Accessible only within the containing class or struct.                       |
| `protected`  | Accessible within the containing class and its derived classes.              |
| `internal`   | Accessible within the same assembly, but not from another assembly.          |
| `protected internal` | Accessible within the same assembly or from derived classes.         |
| `private protected`  | Accessible within the containing class or derived classes in the same assembly. |

## Example

```csharp
public class Example
{
    public int PublicField;
    private int PrivateField;
    protected int ProtectedField;
    internal int InternalField;
    protected internal int ProtectedInternalField;
    private protected int PrivateProtectedField;
}
```

## Default Access Specifier

If no access specifier is explicitly declared:

- **Top-level types (classes, interfaces, etc.)** are `internal` by default.
- **Members of a class or struct** are `private` by default.

For example:

```csharp
class MyClass // internal by default
{
    int myField; // private by default
}
```

## Object-Oriented Concepts in C#

C# is an object-oriented programming language that supports the following key concepts:

- **Encapsulation**: Bundling data and methods that operate on the data within a single unit (class), and restricting access to some of the object's components.
- **Abstraction**: Hiding complex implementation details and showing only the necessary features of an object.
- **Inheritance**: Allowing a class to inherit members (fields, methods, etc.) from another class, promoting code reuse.
- **Polymorphism**: Allowing objects to be treated as instances of their parent class rather than their actual class, enabling one interface to be used for different data types.

These concepts help in designing modular, reusable, and maintainable code.

## Method Overloading in C#

Method overloading in C# allows multiple methods in the same class to have the same name but different parameter lists (type, number, or order of parameters). The compiler determines which method to invoke based on the arguments passed.

### Rules for Overloading

- Methods must differ in the number, type, or order of parameters.
- Return type alone is not sufficient for overloading.
- Optional parameters and params arrays can affect overload resolution.

### Example

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

In the example above, the `Add` method is overloaded with different parameter types and counts.

## Types of Variables in C#

Variables in C# are used to store data. They are categorized based on their data type and scope.

### 1. Based on Data Type

- **Value Types**: Store actual data. Examples include `int`, `float`, `double`, `char`, `bool`, `struct`, and `enum`.
- **Reference Types**: Store references to the actual data. Examples include `string`, `class`, `interface`, `delegate`, and arrays.

| Type           | Example           | Description                                  |
|----------------|-------------------|----------------------------------------------|
| `int`          | `int age = 25;`   | 32-bit integer                               |
| `double`       | `double price = 9.99;` | 64-bit floating-point number           |
| `char`         | `char grade = 'A';` | Single Unicode character                  |
| `bool`         | `bool isActive = true;` | Boolean value (true/false)             |
| `string`       | `string name = "Alice";` | Sequence of characters                 |
| `object`       | `object obj = new Object();` | Base type for all data types      |

### 2. Based on Scope

- **Local Variables**: Declared inside methods and accessible only within that method.
- **Instance Variables (Fields)**: Declared inside a class but outside any method. Each object has its own copy.
- **Static Variables**: Declared with the `static` keyword. Shared among all instances of a class.
- **Constant Variables**: Declared with the `const` keyword. Value cannot be changed after initialization.
- **Read-only Variables**: Declared with the `readonly` keyword. Value can be assigned only during declaration or in the constructor.

### Example

```csharp
public class Person
{
    // Instance variable
    public string Name;

    // Static variable
    public static int Population;

    // Constant variable
    public const double Pi = 3.14159;

    // Read-only variable
    public readonly DateTime BirthDate;

    public void Display()
    {
        // Local variable
        int age = 30;
        Console.WriteLine($"Name: {Name}, Age: {age}");
    }

    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
    }
}
```

### Notes

- Local variables must be initialized before use.
- Instance and static variables get default values if not explicitly initialized.
- Constants must be assigned at declaration.
- Read-only variables can be assigned in the constructor.

### static method rules

* a static method can access only static variables and non static members cannot be accessed
* a non static method can access both static members as well as non static members
