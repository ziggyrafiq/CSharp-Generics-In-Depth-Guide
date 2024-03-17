//The File Name is Program.cs
using ApiLibraryExample;

ApiLibrary api = new ApiLibrary();

// Covariant usage
IEnumerable<string> items = api.GetItems().Cast<string>();
foreach (var item in items)
{
    Console.WriteLine($"Item: {item}");
}

// Contravariant usage
api.SetItem("New item");