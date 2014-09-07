using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmNow.Repository.Interfaces
{
     public interface IDeleteRepository<T>
    {
        bool Delete(T item);
    }
}

