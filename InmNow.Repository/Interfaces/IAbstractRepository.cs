using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmNow.Domain;

namespace InmNow.Repository.Interfaces
{
    public interface IAbstractRepository : IReadRepository<Domain.Models.Abstract>, ICreateRepository<Domain.Models.Abstract>, IUpdateRepository<Domain.Models.Abstract>,
        IDeleteRepository<Domain.Models.Abstract>
    {

    }
}

