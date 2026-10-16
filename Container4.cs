namespace c__Advanced_ass1;

public class Container4<T> where T : IPrintable
{
    public void Show(T item)
    {
        item.Print();
    }

}
