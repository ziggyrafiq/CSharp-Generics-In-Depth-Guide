//The File Name is Program.cs
// Creating a HashSet of integers
HashSet<int> uniqueNumbers = new HashSet<int>();

// Adding unique numbers
uniqueNumbers.Add(10);
uniqueNumbers.Add(20);
uniqueNumbers.Add(10); // Duplicate, will be ignored

// Iterating through unique numbers
Console.WriteLine("Unique Numbers in HashSet:");
foreach (var number in uniqueNumbers)
{
    Console.WriteLine(number);
}

// Adding more unique numbers
uniqueNumbers.Add(30);
uniqueNumbers.Add(40);

// Iterating through the updated HashSet
Console.WriteLine("\nUpdated Unique Numbers in HashSet:");
foreach (var number in uniqueNumbers)
{
    Console.WriteLine(number);
}

// Checking for the existence of a number
int checkNumber = 20;
bool containsNumber = uniqueNumbers.Contains(checkNumber);
Console.WriteLine($"\nIs {checkNumber} in the HashSet? {containsNumber}");

// Removing a number from the HashSet
int removedNumber = 10;
bool removedSuccessfully = uniqueNumbers.Remove(removedNumber);

if (removedSuccessfully)
{
    Console.WriteLine($"\nRemoved {removedNumber} from the HashSet.");
}
else
{
    Console.WriteLine($"\n{removedNumber} not found in the HashSet.");
}

// Iterating through the final HashSet
Console.WriteLine("\nFinal Unique Numbers in HashSet:");
foreach (var number in uniqueNumbers)
{
    Console.WriteLine(number);
}