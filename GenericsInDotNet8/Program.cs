//The File Name is Program.cs
// Create an instance of a class implementing IDataProvider<string>
using GenericsInDotNet8;

IDataProvider<string> stringDataProvider = new StringDataProvider();

// Get and display data
string data = stringDataProvider.GetData();
Console.WriteLine($"Data from StringDataProvider: {data}");
