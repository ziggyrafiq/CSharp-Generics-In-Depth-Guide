//The File Name is ListProcessor.cs
namespace ListProcessorExample;

public delegate TOutput Transformer<TInput, TOutput>(TInput input);

public static class ListProcessor
{
    public static List<TResult> ProcessList<T, TResult>(List<T> inputList, Transformer<T, TResult> transformer)
    {
        List<TResult> result = new List<TResult>();

        foreach (var item in inputList)
        {
            result.Add(transformer(item));
        }

        return result;
    }

    // Custom transformation: square the input number
    public static int Square(int number)
    {
        return number * number;
    }
}
