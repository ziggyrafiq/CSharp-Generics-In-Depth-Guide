//The File Name is Data.cs
namespace CachingDictionary;
public static class Data
{
    public static string RetrieveDataFromDatabase(string key)
    {
        // Simulated database retrieval
        return $"Data for {key}";
    }
}
