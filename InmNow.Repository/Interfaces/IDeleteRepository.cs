namespace InmNow.Repository.Interfaces
{
     public interface IDeleteRepository<T>
    {
        bool Delete(T item);
    }
}

