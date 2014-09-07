using InmNow.Domain.Models;

namespace InmNow.Logic.Interfaces
{
    public interface IAbstractsCollective
    {
        Abstract GetAbstractById(int abstractId);
        Abstract GetAbstractByLognumber(int lognumber);
        Abstract CreateAbstract(Abstract newAbstract);
        Abstract UpsertAbstract(Abstract abstractUpdate);
    }
}
