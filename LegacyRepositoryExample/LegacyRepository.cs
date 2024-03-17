//The File Name is public class LegacyRepository.cs
// Dealing with legacy code and variance
namespace LegacyRepositoryExample;
public class LegacyRepository : IReadOnlyRepository<LegacyEntity>
{
    private readonly List<LegacyEntity> legacyData; // Simulating legacy data storage

    public LegacyRepository()
    {
        // Initialize or fetch legacy data from a data source
        legacyData = FetchLegacyData();
    }

    public IEnumerable<LegacyEntity> GetAll()
    {
        // Logic for fetching legacy entities
        return legacyData;
    }

    private List<LegacyEntity> FetchLegacyData()
    {
        // Replace this logic with actual code to fetch data from a legacy data source
        // For demonstration, returning a sample list
        return new List<LegacyEntity>
        {
            new LegacyEntity { Id = 1, Name = "LegacyEntity One" },
            new LegacyEntity { Id = 2, Name = "LegacyEntity Two" },
            new LegacyEntity { Id = 3, Name = "LegacyEntity Three" }
        };
    }
}
