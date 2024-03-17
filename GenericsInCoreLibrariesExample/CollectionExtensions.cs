//The File Name is CollectionExtensions.cs
using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericsInCoreLibrariesExample;
public static class CollectionExtensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}
