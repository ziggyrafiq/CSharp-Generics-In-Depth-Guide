//The File Name is TransformerExtensions.cs
namespace CompositeTransformationsExample;

// Define a generic delegate named Transformer
public delegate TOutput Transformer<TInput, TOutput>(TInput input);
public static class TransformerExtensions
{
    // Compose method to combine two Transformers
    public static Transformer<TInput, TResult> Compose<TInput, TIntermediate, TResult>(
        this Transformer<TInput, TIntermediate> first,
        Transformer<TIntermediate, TResult> second)
    {
        return input => second(first(input));
    }
}
