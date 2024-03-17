//The File Name is Program.cs
// Using immutable collections
using System.Collections.Immutable;

ImmutableList<int> immutableList = ImmutableList<int>.Empty
    .Add(1)
    .Add(2)
    .Add(3);

// Displaying the immutable list
Console.WriteLine("Immutable List:");
Console.WriteLine(string.Join(", ", immutableList));