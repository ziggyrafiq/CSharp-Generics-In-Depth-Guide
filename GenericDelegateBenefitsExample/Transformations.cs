//The File Name is Transformations.cs
namespace GenericDelegateBenefitsExample;

// Define a generic delegate named Transformer
public delegate TOutput Transformer<TInput, TOutput>(TInput input);
public static class Transformations
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
