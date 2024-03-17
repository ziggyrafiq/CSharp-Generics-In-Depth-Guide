//The File Name is Calculator.cs
namespace StructuredCalculatorV1;
public class Calculator<T> where T : struct, INumber
{
    public T Add(T a, T b)
    {
        return (dynamic)a + b;
    }

    public T Multiply(T a, T b)
    {
        return (dynamic)a * b;
    }
}
