//The File Name is INumber.cs
// Marker interface for numeric types
namespace StructuredCalculatorV1;
public interface INumber
{

    // Get the absolute value of the number
    double AbsoluteValue();

    // Compare two numbers
    int CompareTo(INumber other);

    // Convert the number to a string representation
    string ToString();
}
 