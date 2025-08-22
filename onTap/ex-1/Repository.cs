

public class Repository<T> where T : class
{
    private List<T> items = new List<T>();

    public void AddFunc(T item)
    {
        items.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }
}