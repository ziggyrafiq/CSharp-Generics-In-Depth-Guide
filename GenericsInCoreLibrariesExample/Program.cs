//The File Name is Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

using GenericsInCoreLibrariesExample;
// Example usage of generics in LINQ extension methods
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filter even numbers
var evenNumbers = numbers.Filter(x => x % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var number in evenNumbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();