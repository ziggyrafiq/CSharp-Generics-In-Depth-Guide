//Class File Name is Program.cs
// Example usage of ConstraintsDemo with a class that meets the constraints
using Constraints;

ConstraintsDemo<MyClass> classDemo = new ConstraintsDemo<MyClass>();
classDemo.MyConstrainedMethod(new MyClass());

// Example usage of ConstraintsDemo with a class that doesn't meet the constraints (compile-time error)
// ConstraintsDemo<NotValidClass> invalidClassDemo = new ConstraintsDemo<NotValidClass>(); // Uncommenting this line would result in a compile-time error