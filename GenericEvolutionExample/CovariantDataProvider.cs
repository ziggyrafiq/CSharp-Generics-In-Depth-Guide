//The File Name is CovariantDataProvider.cs

namespace GenericEvolutionExample;

// .NET Framework 4.0: Covariant interface
public class CovariantDataProvider : ICovariantDataProvider<string>
{
    public string GetData()
    {
        return "Data from CovariantDataProvider";
    }
}
