//The File Name is Program.cs
// Real-world example: Caching with Dictionary
Dictionary<string, string> cache = new Dictionary<string, string>();
string key = "user_profile_123";

// Using TryGetValue for efficient key retrieval
if (!cache.TryGetValue(key, out string cachedValue))
{
    // Retrieve data from the database
    cachedValue = CachingDictionary.Data.RetrieveDataFromDatabase(key);

    // Adding the retrieved data to the cache using TryAdd to handle potential key collisions
    if (cache.TryAdd(key, cachedValue))
    {
        Console.WriteLine("Data successfully added to the cache.");
    }
    else
    {
        Console.WriteLine("Data was not added to the cache due to a key collision.");
    }
}
else
{
    Console.WriteLine("Data retrieved from the cache: " + cachedValue);
}
    

   