//The File Name is Program.cs
// Create an instance of the contravariant implementation
using ContravariantInterface;

ContravariantImplementation<object> objectImplementation = new ContravariantImplementation<object>();

// Use the contravariant interface
IContravariant<string> stringContravariant = objectImplementation; // Contravariant assignment

// Set an item using the contravariant interface
stringContravariant.SetItem("Hello, Contravariance!");