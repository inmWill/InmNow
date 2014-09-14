namespace InmNow.Repository.Interfaces
{
    public interface IUpdateRepository<T>
    {
        T Update(T item);
    }
}
