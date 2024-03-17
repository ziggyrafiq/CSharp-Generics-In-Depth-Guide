//The File Name is ContravariantDelegate.cs
namespace ContravariantDelegate;

public delegate void ContravariantDelegate<in T>(T item);