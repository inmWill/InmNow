using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using InmNow.Repository.DbContexts;
using InmNow.Repository.Interfaces;
using InmNow.Repository.Models;
using InmNow.Utils.AutoMapper;

namespace InmNow.Repository.Repositories
{
    public class InmUserRepository : IInmUserRepository
    {

        InmergeNowContext Context { get; set; }

        public InmUserRepository()
        {
            Context = new InmergeNowContext();
            AutoMapperConfig.CreateMap<Domain.Models.InmUser, Repository.Models.InmUser>();
            AutoMapperConfig.CreateMap<Repository.Models.InmUser, Domain.Models.InmUser>();
         

        }

        public Domain.Models.InmUser Create(Domain.Models.InmUser item)
        {
            var action = Mapper.Map<Repository.Models.InmUser>(item);
            try
            {
                Context.Users.Add(action);
                Context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Delete(Domain.Models.InmUser item)
        {
            var action = Mapper.Map<Repository.Models.InmUser>(item);
            try
            {
                Context.InmUsers.Remove(action);
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Domain.Models.InmUser Update(Domain.Models.InmUser item)
        {
            var action = Mapper.Map<Repository.Models.InmUser>(item);
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

        public IQueryable<Domain.Models.InmUser> GetAll()
        {
            try
            {
                return Context.InmUsers.AsQueryable().Project().To<Domain.Models.InmUser>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Domain.Models.InmUser> FindAll(Expression<Func<Domain.Models.InmUser, bool>> where = null)
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

        public Domain.Models.InmUser GetByUserName(string userName)
        {
            return FindOne(a => a.UserName == userName);
        }

        public Domain.Models.InmUser Get(int userId)
        {
            return FindOne(a => a.UserId == userId);
        }

        public Domain.Models.InmUser FindOne(Expression<Func<Domain.Models.InmUser, bool>> where = null)
        {
            return FindAll(where).FirstOrDefault();
        }

    }
}

