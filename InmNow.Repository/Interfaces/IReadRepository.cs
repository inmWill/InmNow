using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InmNow.Repository.Interfaces
{
    public interface IReadRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        IQueryable<T> FindAll(Expression<Func<T, bool>> where = null);
        T FindOne(Expression<Func<T, bool>> where = null);
    }
}
