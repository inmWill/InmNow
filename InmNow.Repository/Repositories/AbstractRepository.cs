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
    public class AbstractRepository : IAbstractRepository
    {
        
        InmergeNowContext Context { get; set; }

        public AbstractRepository()
        {
            Context = new InmergeNowContext();
            AutoMapperConfig.CreateMap<Domain.Models.Abstract, Repository.Models.Abstract>();

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.Abstract, Domain.Models.Abstract>()
                    .ForMember(t=>t.AbstractOptions, opt=>opt.Ignore())
                    .ForMember(t=>t.AbstractUsers, opt=>opt.Ignore())
                    .ForMember(t => t.AspNetUser, opt => opt.Ignore())
                    .ForMember(t => t.Session, opt => opt.Ignore())
                    .ForMember(t => t.Sessions, opt => opt.Ignore());
            }
            catch
            {
                
            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.AbstractUser, Domain.Models.AbstractUser>()
                    .ForMember(t => t.Abstract, opt => opt.Ignore());
            }
            catch
            {

            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.AspNetUser, Domain.Models.AspNetUser>()
                    .ForMember(t => t.Abstracts, opt => opt.Ignore());
            }
            catch
            {

            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.AbstractOption, Domain.Models.AbstractOption>()
                    .ForMember(t => t.Abstract, opt => opt.Ignore());
            }
            catch
            {
                //exists
            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.Option, Domain.Models.Option>()
                    .ForMember(t => t.AbstractOptions, opt => opt.Ignore());
            }
            catch
            {
                //exists
            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.Meeting, Domain.Models.Meeting>()
                    .ForMember(t => t.Options, opt => opt.Ignore());
            }
            catch
            {
                //exists
            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.Track, Domain.Models.Track>()
                    .ForMember(t => t.Meeting, opt => opt.Ignore());
            }
            catch
            {
                //exists
            }

            try
            {
                AutoMapperConfig.CreateMap<Repository.Models.Session, Domain.Models.Session>()
                    .ForMember(t => t.Track, opt => opt.Ignore());
            }
            catch
            {
                //exists
            }

        }

        public Domain.Models.Abstract Create(Domain.Models.Abstract item)
        {
            var action = Mapper.Map<Repository.Models.Abstract>(item);
            try
            {
                Context.Abstracts.Add(action);
                Context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool Delete(Domain.Models.Abstract item)
        {
            var action = Mapper.Map<Repository.Models.Abstract>(item);
            try
            {
                Context.Abstracts.Remove(action);
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Domain.Models.Abstract Update(Domain.Models.Abstract item)
        {
            var action = Mapper.Map<Repository.Models.Abstract>(item);
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

        public IQueryable<Domain.Models.Abstract> GetAll()
        {
            try
            {
                return Context.Abstracts.AsQueryable().Project().To<Domain.Models.Abstract>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Domain.Models.Abstract> FindAll(Expression<Func<Domain.Models.Abstract, bool>> where = null)
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

        public Domain.Models.Abstract Get(int id)
        {
            return FindOne(a => a.AbstractId == id);
        }

        public Domain.Models.Abstract FindOne(Expression<Func<Domain.Models.Abstract, bool>> where = null)
        {
            return FindAll(where).FirstOrDefault();
        }

    }
}

