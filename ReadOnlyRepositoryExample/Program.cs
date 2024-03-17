//The File Name is Program.cs
using ReadOnlyRepositoryExample;

IReadOnlyRepository<string> stringRepository = new ReadOnlyRepository<string>(new List<string> { "apple", "banana", "cherry" });

foreach (var item in stringRepository.GetAll())
{
    Console.WriteLine(item);
}