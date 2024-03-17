//The File Name is Program.cs
using LegacyRepositoryExample;

IReadOnlyRepository<LegacyEntity> legacyRepository = new LegacyRepository();

foreach (var legacyEntity in legacyRepository.GetAll())
{
    Console.WriteLine($"Legacy Entity: {legacyEntity.Id} - {legacyEntity.Name}");
}