//The File Name is AnimalDataProvider.cs
namespace GenericEvolutionExample;

// .NET 8: Covariant return types
public class AnimalDataProvider : IDataProvider<Animal>
{
    public Animal GetData()
    {
        return new Animal { Name = "Lion" };
    }
}
