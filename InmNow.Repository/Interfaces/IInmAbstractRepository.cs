namespace InmNow.Repository.Interfaces
{
    public interface IInmAbstractRepository : IReadRepository<Domain.Models.InmAbstract>, ICreateRepository<Domain.Models.InmAbstract>, IUpdateRepository<Domain.Models.InmAbstract>,
        IDeleteRepository<Domain.Models.InmAbstract>
    {

    }
}

