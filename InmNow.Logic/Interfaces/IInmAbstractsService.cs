using System.Linq;
using InmNow.Domain.Models;

namespace InmNow.Service.Interfaces
{
    public interface IInmAbstractsService
    {
        InmAbstract GetAbstractById(int abstractId);
        IQueryable<InmAbstract> GetAll();
        InmAbstract CreateAbstract(InmAbstract newAbstract);
        InmAbstract UpsertAbstract(InmAbstract abstractUpdate);
    }
}
