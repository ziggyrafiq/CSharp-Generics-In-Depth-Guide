//The File Name is Program.cs
// Creating a List of Person objects
using UsingListDynamicListObjects;

List<Person> people = new List<Person>();

// Adding Person objects to the List
people.Add(new Person { Name = "Alice", Age = 25 });
people.Add(new Person { Name = "Bob", Age = 30 });

// Iterating through the list and printing details
Console.WriteLine("People List Details:");
foreach (var person in people)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

// Modifying a person's age
Person alice = people.Find(p => p.Name == "Alice");
if (alice != null)
{
    alice.Age = 26;
    Console.WriteLine("\nAfter Modifying Alice's Age:");
    Console.WriteLine($"Name: {alice.Name}, Updated Age: {alice.Age}");
}

// Adding more people to the list
people.Add(new Person { Name = "Charlie", Age = 35 });
people.Add(new Person { Name = "David", Age = 28 });

// Iterating through the updated list
Console.WriteLine("\nUpdated People List:");
foreach (var person in people)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

// Removing a person from the list
Person removedPerson = people.Find(p => p.Name == "Bob");
if (removedPerson != null)
{
    people.Remove(removedPerson);
    Console.WriteLine("\nAfter Removing Bob:");
    foreach (var person in people)
    {
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}