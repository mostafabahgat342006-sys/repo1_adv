namespace c__Advanced_ass1;

public class Container3<T> where T : new()
{

    public T Create()
    {
        return new T();
    }


}
