//The File Name is Program.cs
// Creating a Dictionary to store ages based on names
Dictionary<string, int> ages = new Dictionary<string, int>();

// Adding age information
ages.Add("Alice", 25);
ages.Add("Bob", 30);

// Retrieving age based on name
string targetName = "Alice";
if (ages.TryGetValue(targetName, out int age))
{
    Console.WriteLine($"Age of {targetName}: {age}");
}
else
{
    Console.WriteLine($"No age information found for {targetName}");
}

// Modifying age information
string modifiedName = "Alice";
int modifiedAge = 26;

if (ages.ContainsKey(modifiedName))
{
    ages[modifiedName] = modifiedAge;
    Console.WriteLine($"\nUpdated age for {modifiedName}: {ages[modifiedName]}");
}

// Adding more age information
ages["Charlie"] = 35;
ages["David"] = 28;

// Iterating through the updated Dictionary
Console.WriteLine("\nUpdated Ages Dictionary:");
foreach (var kvp in ages)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Removing age information
string removedName = "Bob";
if (ages.ContainsKey(removedName))
{
    ages.Remove(removedName);
    Console.WriteLine($"\nAfter Removing {removedName} from Ages Dictionary:");
    foreach (var kvp in ages)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}