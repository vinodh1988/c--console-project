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