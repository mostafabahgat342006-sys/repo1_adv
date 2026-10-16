namespace c__Advanced_ass1;

public interface IRepository<T>
{
    void Add(T item);
    T GetById(int id);


}
