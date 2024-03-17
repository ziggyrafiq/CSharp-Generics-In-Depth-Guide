//The File Name is NumericValue.cs
namespace StructuredCalculatorV1;
public struct NumericValue : INumber
{
    private readonly double value;

    public NumericValue(double value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public double AbsoluteValue()
    {
        return Math.Abs(value);
    }

    public int CompareTo(INumber other)
    {
        if (other is NumericValue numericValue)
        {
            return value.CompareTo(numericValue.value);
        }
        else
        {
            throw new ArgumentException("Comparison with a non-numeric type is not supported.");
        }
    }

    // Operator overloads for addition and multiplication
    public static NumericValue operator +(NumericValue a, NumericValue b)
    {
        return new NumericValue(a.value + b.value);
    }

    public static NumericValue operator *(NumericValue a, NumericValue b)
    {
        return new NumericValue(a.value * b.value);
    }
}