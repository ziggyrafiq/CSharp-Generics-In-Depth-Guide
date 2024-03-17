//The File Name is AnimalEventArgs.cs 
namespace EventHandlingCovarianceExample;
public class AnimalEventArgs : EventArgs
{
    public string AnimalName { get; }

    public AnimalEventArgs(string animalName)
    {
        AnimalName = animalName;
    }
}
