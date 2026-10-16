namespace c__Advanced_ass1;

public class SafeList<T>
{

    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T Get(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }

        return default(T);
    }



}
