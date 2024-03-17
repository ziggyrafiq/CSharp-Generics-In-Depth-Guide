//The File Name is Program.cs
using GenericDebuggerVisualStudioExample;

// Example usage of debugging generic classes
var intBox = new Box<int>(42);

// Set a breakpoint on the following line and use Visual Studio debugger to inspect 'intBox'
Console.WriteLine($"Content of the intBox: {intBox.Content}");