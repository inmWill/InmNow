using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InmNow.Repository.Interfaces;
using InmNow.Domain.Models;
using InmNow.Repository.Models;
using InmNow.Utils.AutoMapper;

namespace InmNow.Repository.Repositories
{
    public class InmAbstractRepository : IInmAbstractRepository
    {
        
        InmergeNowContext Context { get; set; }

        public InmAbstractRepository()
        {
            Context = new InmergeNowContext();
            AutoMapperConfig.CreateMap<Domain.Models.InmAbstract, Repository.Models.InmAbstract>();
            AutoMapperConfig.CreateMap<Repository.Models.InmAbstract, Domain.Models.InmAbstract>();
         

        }

        public Domain.Models.InmAbstract Create(Domain.Models.InmAbstract item)
        {
            var action = Mapper.Map<Repository.Models.InmAbstract>(item);
            try
            {
                Context.InmAbstracts.Add(action);
                Context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool Delete(Domain.Models.InmAbstract item)
        {
            var action = Mapper.Map<Repository.Models.InmAbstract>(item);
            try
            {
                Context.InmAbstracts.Remove(action);
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Domain.Models.InmAbstract Update(Domain.Models.InmAbstract item)
        {
            var action = Mapper.Map<Repository.Models.InmAbstract>(item);
            try
            {
                Context.Entry(action).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Domain.Models.InmAbstract> GetAll()
        {
            try
            {
                return Context.InmAbstracts.AsQueryable().Project().To<Domain.Models.InmAbstract>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Domain.Models.InmAbstract> FindAll(Expression<Func<Domain.Models.InmAbstract, bool>> where = null)
        {
            try
            {
                return null != where ? GetAll().Where(where) : GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Domain.Models.InmAbstract Get(int id)
        {
            return FindOne(a => a.InmAbstractId == id);
        }

        public Domain.Models.InmAbstract FindOne(Expression<Func<Domain.Models.InmAbstract, bool>> where = null)
        {
            return FindAll(where).FirstOrDefault();
        }

    }
}

