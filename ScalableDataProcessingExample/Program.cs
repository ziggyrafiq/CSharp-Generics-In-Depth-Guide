//The File Name is Program.cs
// Example usage of scalable data processing with generic algorithms
using ScalableDataProcessingExample;

var largeDataSet = GenerateLargeDataSet();

// Process the large dataset using generic data processor
DataProcessor<string>.ProcessData(largeDataSet);