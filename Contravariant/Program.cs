//The File Name is Program.cs
// Contravariant scenario
Action<object> printObject = obj => Console.WriteLine(obj);
Action<string> printString = printObject; // Contravariant assignment

// Invoke the contravariant delegate
printString("Hello, Contravariance!");