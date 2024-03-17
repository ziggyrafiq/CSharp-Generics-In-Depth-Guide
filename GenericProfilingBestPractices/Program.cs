//The File Name is Program.cs
// Example usage of profiling best practices
using GenericProfilingBestPractices;

var algorithm = new GenericAlgorithm<int>();

// Generate a large array of integers for profiling
var largeArray = Helpers.GenerateLargeArray();

// Profiling the FindMaximum method
Helpers.ProfileFindMaximum(algorithm, largeArray);