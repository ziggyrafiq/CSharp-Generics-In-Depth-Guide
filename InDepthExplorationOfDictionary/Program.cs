//The File Name is Program.cs
// Creating a Dictionary with string keys and int values
Dictionary<string, int> ages = new Dictionary<string, int>();

// Adding key-value pairs
ages.Add("Alice", 25);
ages.Add("Bob", 30);

// Accessing values
Console.WriteLine($"Age of Alice: {ages["Alice"]}");

// Modifying a value
ages["Bob"] = 32;

// Adding more key-value pairs
ages["Charlie"] = 28;
ages["David"] = 35;

// Accessing modified and new values
Console.WriteLine("\nModified Dictionary with Additional Key-Value Pairs:");
foreach (var person in ages)
{
    Console.WriteLine($"{person.Key}: {person.Value}");
}

// Removing a key-value pair
ages.Remove("Alice");

// Accessing values after removal
Console.WriteLine("\nDictionary after Removing a Key-Value Pair:");
foreach (var person in ages)
{
    Console.WriteLine($"{person.Key}: {person.Value}");
}

// Checking if the Dictionary contains a specific key
bool containsKey = ages.ContainsKey("Charlie");
Console.WriteLine($"\nDictionary contains key 'Charlie': {containsKey}");

// Trying to retrieve a value safely
string targetName = "Alice";
if (ages.TryGetValue(targetName, out int age))
{
    Console.WriteLine($"Age of {targetName}: {age}");
}
else
{
    Console.WriteLine($"No age information found for {targetName}");
}