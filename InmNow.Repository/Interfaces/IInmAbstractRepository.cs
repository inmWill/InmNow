using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmNow.Domain;

namespace InmNow.Repository.Interfaces
{
    public interface IInmAbstractRepository : IReadRepository<Domain.Models.InmAbstract>, ICreateRepository<Domain.Models.InmAbstract>, IUpdateRepository<Domain.Models.InmAbstract>,
        IDeleteRepository<Domain.Models.InmAbstract>
    {

    }
}

