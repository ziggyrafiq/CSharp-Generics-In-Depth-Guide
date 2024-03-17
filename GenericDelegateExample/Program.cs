//The File Name is Program.cs
using GenericDelegateExample;

// Example 1: Transforming integers to strings
Transformer<int, string> intToStringTransformer = Transformers.ConvertIntToString;
Console.WriteLine($"Transformed result: {intToStringTransformer(123)}");

// Example 2: Transforming strings to uppercase
Transformer<string, string> toUppercaseTransformer = Transformers.ConvertToUppercase;
Console.WriteLine($"Transformed result: {toUppercaseTransformer("hello")}");

// Example 3: Transforming doubles to integers
Transformer<double, int> doubleToIntTransformer = Transformers.ConvertDoubleToInt;
Console.WriteLine($"Transformed result: {doubleToIntTransformer(45.67)}");

// Example 4: Custom transformation
Transformer<string, int> customTransformer = Transformers.CustomTransform;
Console.WriteLine($"Transformed result: {customTransformer("987")}");