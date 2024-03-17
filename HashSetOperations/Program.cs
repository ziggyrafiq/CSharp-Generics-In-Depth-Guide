//The File Name is Program.cs
// Performing set operations with HashSets
HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

// Displaying the original sets
Console.WriteLine("Original Sets:");
Console.WriteLine($"Set1: {string.Join(", ", set1)}");
Console.WriteLine($"Set2: {string.Join(", ", set2)}");

// Union
var unionSet = new HashSet<int>(set1);
unionSet.UnionWith(set2);

// Displaying the Union set
Console.WriteLine("\nUnion Set:");
Console.WriteLine(string.Join(", ", unionSet));

// Intersection
var intersectionSet = new HashSet<int>(set1);
intersectionSet.IntersectWith(set2);

// Displaying the Intersection set
Console.WriteLine("\nIntersection Set:");
Console.WriteLine(string.Join(", ", intersectionSet));

// Difference
var differenceSet = new HashSet<int>(set1);
differenceSet.ExceptWith(set2);

// Displaying the Difference set
Console.WriteLine("\nDifference Set (Set1 - Set2):");
Console.WriteLine(string.Join(", ", differenceSet));