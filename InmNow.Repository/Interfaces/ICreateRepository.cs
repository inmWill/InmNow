namespace InmNow.Repository.Interfaces
{
   public interface ICreateRepository<T>
    {
        T Create(T item);
    }
}