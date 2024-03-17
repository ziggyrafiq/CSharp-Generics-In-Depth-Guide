//The File Name is Program.cs
// Example 1: Transforming integers to strings
using GenericDelegateBenefitsExample;


Transformer<int, string> intToStringTransformer = Transformations.ConvertIntToString;
Console.WriteLine($"Transformed result: {intToStringTransformer(123)}");

// Example 2: Transforming strings to uppercase
Transformer<string, string> toUppercaseTransformer = Transformations.ConvertToUppercase;
Console.WriteLine($"Transformed result: {toUppercaseTransformer("hello")}");

// Example 3: Filtering even numbers
GenericDelegateBenefitsExample.Predicate<int> isEven = Predicates.IsEven;
Console.WriteLine($"Is 10 even? {isEven(10)}");
Console.WriteLine($"Is 7 even? {isEven(7)}");

// Example 4: Custom transformation
Transformer<string, int> customTransformer = Transformations.CustomTransform;
Console.WriteLine($"Transformed result: {customTransformer("987")}");