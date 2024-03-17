//The File Name is Program.cs
// Define a transformer to convert int to string
using CompositeTransformationsExample;

Transformer<int, string> intToString = i => i.ToString();

// Define a transformer to convert string to bool
Transformer<string, bool> stringToBool = s => bool.Parse(s);

// Combine the transformers to convert int to bool
Transformer<int, bool> combined = intToString.Compose(stringToBool);

// Test the combined transformer
int inputNumber = 42;
bool result = combined(inputNumber);

// Display the result
Console.WriteLine($"Transformed result: {result}");