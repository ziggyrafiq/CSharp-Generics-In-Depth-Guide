//Console App Example the class file name is Program.cs
using DefiningGenerics;

// Example with MyGenericClass using int as the generic type
MyGenericClass<int> intGenericClass = new MyGenericClass<int>();
int resultInt = intGenericClass.MyMethod(42);
Console.WriteLine($"Result for int: {resultInt}");

// Example with MyGenericClass using string as the generic type
MyGenericClass<string> stringGenericClass = new MyGenericClass<string>();
string resultString = stringGenericClass.MyMethod("Hello, Generics!");
Console.WriteLine($"Result for string: {resultString}");