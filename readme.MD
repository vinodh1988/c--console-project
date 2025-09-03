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