using InmNow.Domain.Models;

namespace InmNow.Logic.Interfaces
{
    public interface IInmAbstractsCollective
    {
        InmAbstract GetAbstractById(int abstractId);
        InmAbstract GetAbstractByLognumber(int lognumber);
        InmAbstract CreateAbstract(InmAbstract newAbstract);
        InmAbstract UpsertAbstract(InmAbstract abstractUpdate);
    }
}
