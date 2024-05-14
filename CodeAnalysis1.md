Given the following:
```csharp
class Animal
{
	public virtual string speak(int x) { return "silence"; }
}

class Cat : Animal
{
	public string speak(int x) { return "meow"; }
}

class Dog : Animal
{
	public string speak(short x) { return "bow-wow"; }
}
```
Question: Explain why the block below does not emit “bow-wow”:
```csharp
Animal d = new Dog();
Console.Write(d.speak(0));
```
# Code Analysis
The output obviously will be
```
silence
```
This happens because we're casting **Dog** type to **Animal** and thus calling an **Animal**'s method. 
Since **Dog.speak** declared without `virtual` keyword, it won't replace **Animal**'s method as we might expect. Rather we're creating a new method in Dog class and compiler will warn us about that. To avoid the compiler's warning and make our intentions clear, we may declare **Dog.speak** by one of following ways:
- use `new` keyword to create a new method, *not related* to **Animal**'s implementation
- use `override` keyword to *replace* the **Animal**'s one.
using `new` won't change the output (`silence`) but will remove the compiler's warning.
Using `override` will cause displaying `bow-wow`.
# Additional Considerations - interfaces instead of inheritance
Another question is whether we really need to use inheritance here?
Not **all** animals *speak*. Not **only** animals *speak*. *Jellyfish* (or any other fish) is animal, whereas *Amazon Alexa* - isn't.
When considering design, we need to answer question - are we sharing the implementation? Is speaking an integral part of *Animal* type - or it's an optional ability?
If latter - it makes sense to introduce an interface, let's say **ISpeakable**:
```csharp
interface ISpeakable
{
	string Speak(int x);
}
```
which such animals as **Cat** or **Dog** (or `class Mammal: Animal, ISpeakable`) will implement.
