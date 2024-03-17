//The File Name is NumericValue.cs
namespace FlexibleCalculatorV2;
public struct NumericValue
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