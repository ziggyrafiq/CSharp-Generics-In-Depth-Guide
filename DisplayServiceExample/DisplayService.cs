//The File Name is DisplayService.cs
namespace DisplayServiceExample;
public class DisplayService<T> where T : IDisplayable
{
    private readonly List<T> items;

    public DisplayService()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAll()
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}
