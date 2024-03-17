//The File Name is Transformers.cs
namespace GenericDelegateExample;

public delegate TOutput Transformer<TInput, TOutput>(TInput input);
public static class Transformers
{
    // Method to convert int to string
    public static string ConvertIntToString(int input)
    {
        return input.ToString();
    }

    // Method to convert string to uppercase
    public static string ConvertToUppercase(string input)
    {
        return input.ToUpper();
    }

    // Method to convert double to int
    public static int ConvertDoubleToInt(double input)
    {
        return (int)input;
    }

    // Custom transformation: string to int
    public static int CustomTransform(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input for custom transformation.");
            return 0;
        }
    }
}
