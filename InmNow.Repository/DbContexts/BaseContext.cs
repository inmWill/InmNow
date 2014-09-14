using System.Data.Entity;

namespace InmNow.Repository.Models
{
  public class BaseContext<TContext> 
    : DbContext where TContext : DbContext
  {
    static BaseContext()
    {
      Database.SetInitializer<TContext>(null);
    }
    protected BaseContext()
        : base("Name=InmergeNowContext")
    {}
  }
 }
