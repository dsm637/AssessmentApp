Given the following:
```csharp
class A
{
	public int a { get; set; }
	public int b { get; set; }
}

class B
{
	public const A a;
	public B() { a.a = 10; }
}

int main()
{
	B b = new B();
	Console.WriteLine("%d %d\n", b.a.a, b.a.b);
	return 0;
}
```
Question: Outline any issues/concerns with the implemented code.
# Issues and concerns with the implemented code
Let's start from the fact that code provided neither *C#* nor *C/C++*. *C++* doesn't have get/set operators and concept of properties. *C#* doesn't support *C* format strings (which always will display `%d %d` line ignoring the parameters passed). `main` method declaration is also incorrect, C# uses `Main`, also `Main` method should be part of some type.
What is the purpose of the code? It seems like to demonstrate the ability of working with `const` fields. This obviously won't work in *C#*, because `const` fields are only compile-time constants, like  numbers and string literals - the expressions which value is not changing and can be embedded into the assembly. **A** type is not literal. It's a reference type. For such cases *C#* provide `readonly` keyword. Declaring field as `readonly` will guarantee that the field value won't changed in runtime (except in field initialization or constructor).
But because of using reference, `readonly` won't prevent changing the a fields:
```csharp
B b = new B();
b.a = new A(); // This won't work
b.a.a += 10; // This works
```
Here's how we can convert the code to idiomatic **C#** without beforementioned problems. Also, we will add the `UpdateA` method to **B** type to highlight the ability to change **a**'s fields:
```csharp
class A
{
	public int a { get; set; }
	public int b { get; set; }
}

class B
{
	public readonly A a = new A();
	public B() { a.a = 10; }

	// Will work despite of 'readonly' keyword
	public void UpdateA()
	{
		a.a += 10;
	}
}

internal class Program
{
	static void Main(string[] args)
	{
		B b = new B();
		b.a = new A();
		b.a.a += 10;

		Console.WriteLine("{0:d} {1:d}\n", b.a.a, b.a.b);
		b.UpdateA();
		Console.WriteLine("{0:d} {1:d}\n", b.a.a, b.a.b);
	}
}
```
If we want prevent changing **A's** field values, we could redefine **A**'s properties by following way:
```csharp
class A
{
	public int a { get; init; }
	public int b { get; init; }
}
```
Depending on our requirements, we can declare **A** as a value type using `struct` keyword:
```csharp
struct A
{
	public int a { get; set; }
	public int b { get; set; }
}

class B
{
	public A a = new A { a = 1 };
	public B() { a.a = 10; }
	
	public void UpdateA()
	{
		a.a += 10;
	}
}

internal class Program
{
	static void Main(string[] args)
	{
		B b = new B();

		Console.WriteLine("{0:d} {1:d}\n", b.a.a, b.a.b);
		b.UpdateA();
		Console.WriteLine("{0:d} {1:d}\n", b.a.a, b.a.b);
	}
}
```
This will cause certain changes in the program logic. If we declare field **B.a** as `readonly`, we won't be able to change **a**'s fields:
```csharp
struct A
{
	public int a { get; set; }
	public int b { get; set; }
}

class B
{
	public readonly A a = new A();
	public B() { a.a = 10; }
	
	public void UpdateA()
	{
		a.a += 10; // Compiler error
	}
}
```
## Conclusion
In most cases, if we want to prevent changing **A** declaring the **B.a** as `readonly` and making its properties read-only will be enough.
