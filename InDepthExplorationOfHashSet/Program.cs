//The File Name is Program.cs
// Creating a HashSet of strings
HashSet<string> uniqueNames = new HashSet<string>();

// Adding elements to the HashSet
uniqueNames.Add("Alice");
uniqueNames.Add("Bob");
uniqueNames.Add("Alice"); // Duplicate, will be ignored

// Iterating through unique elements
Console.WriteLine("Unique Names in HashSet:");
foreach (var name in uniqueNames)
{
    Console.WriteLine(name);
}