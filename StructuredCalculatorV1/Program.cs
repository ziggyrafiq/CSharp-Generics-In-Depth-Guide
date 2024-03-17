//The File Name is Program.cs
using StructuredCalculatorV1;

Calculator<NumericValue> calculator = new Calculator<NumericValue>();

NumericValue a = new NumericValue(5.0);
NumericValue b = new NumericValue(3.0);

Console.WriteLine($"Addition: {calculator.Add(a, b)}");
Console.WriteLine($"Multiplication: {calculator.Multiply(a, b)}");
