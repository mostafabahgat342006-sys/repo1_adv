namespace c__Advanced_ass1;

public class Container<T> where T : struct
{
    private T item;
    public T Value { get; set; }
    public void Add(T value)
    {
        item = value;
    }

    public T Get()
    {
        return item;
    }










}
