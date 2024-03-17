//The File Name is AnimalEventArgs.cs
namespace EventHandling;
public class AnimalEventArgs : EventArgs
{
    public string AnimalName { get; }
    public DateTime EventTime { get; }
    public AnimalEventArgs(string animalName)
    {
        AnimalName = animalName;
        EventTime = DateTime.Now;
    }
}
