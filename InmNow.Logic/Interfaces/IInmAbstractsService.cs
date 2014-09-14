using InmNow.Domain.Models;

namespace InmNow.Service.Interfaces
{
    public interface IInmAbstractsService
    {
        InmAbstract GetAbstractById(int abstractId);
        InmAbstract GetAbstractByLognumber(int lognumber);
        InmAbstract CreateAbstract(InmAbstract newAbstract);
        InmAbstract UpsertAbstract(InmAbstract abstractUpdate);
    }
}
