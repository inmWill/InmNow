namespace InmNow.Repository.Interfaces
{
    public interface IInmUserRepository : IReadRepository<Domain.Models.InmUser>, ICreateRepository<Domain.Models.InmUser>, IUpdateRepository<Domain.Models.InmUser>,
        IDeleteRepository<Domain.Models.InmUser>
    {

    }
}

