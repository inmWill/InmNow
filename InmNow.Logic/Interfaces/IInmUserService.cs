using System.Linq;
using InmNow.Domain.Models;

namespace InmNow.Service.Interfaces
{
    public interface IInmUserService
    {
        IQueryable<InmUser> GetAll();
        InmUser GetByUserName(string userName);
        InmUser CreateUser(InmUser newUser);
        InmUser UpsertUser(InmUser userUpdate);
    }
}
