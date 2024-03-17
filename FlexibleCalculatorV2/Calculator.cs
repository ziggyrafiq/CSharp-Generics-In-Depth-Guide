//The File Name is Calculator.cs
namespace FlexibleCalculatorV2;
public class Calculator<T>
{
    public T Add(T a, T b)
    {
        // Check if T is NumericValue and perform addition
        if (a is NumericValue numericA && b is NumericValue numericB)
        {
            return (T)(object)(numericA + numericB);
        }

        throw new ArgumentException($"Addition not supported for type {typeof(T)}");
    }

    public T Multiply(T a, T b)
    {
        // Check if T is NumericValue and perform multiplication
        if (a is NumericValue numericA && b is NumericValue numericB)
        {
            return (T)(object)(numericA * numericB);
        }

        throw new ArgumentException($"Multiplication not supported for type {typeof(T)}");
    }
}