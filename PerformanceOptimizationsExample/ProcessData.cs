//The File Name is ProcessData.cs
namespace PerformanceOptimizationsExample;

// Performance improvement: Span<T> in generic algorithms
public static void ProcessData<T>(Span<T> data)
{
    // Efficient data processing logic
    for (int i = 0; i < data.Length; i++)
    {
        // Modify each element in the span
        data[i] = (T)Convert.ChangeType(Convert.ToInt32(data[i]) * 2, typeof(T));
    }
}
