//The File Name is Program.cs
// Example usage with a Box of type int
using GenericBoxExample;

Box<int> intBox = new Box<int>(42);
intBox.DisplayContent();

// Example usage with a Box of type string
Box<string> stringBox = new Box<string>("Hello, Box!");
stringBox.DisplayContent();