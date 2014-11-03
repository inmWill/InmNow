using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using InmNow.Repository.DbContexts;
using InmNow.Repository.Interfaces;
using InmNow.Utils.AutoMapper;

namespace InmNow.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {

        InmergeNowContext Context { get; set; }

        public ClientRepository()
        {
            Context = new InmergeNowContext();
            AutoMapperConfig.CreateMap<Domain.SurveyBuilder.Models.Client, Repository.Models.Survey.Client>();
            AutoMapperConfig.CreateMap<Repository.Models.Survey.Client, Domain.SurveyBuilder.Models.Client>();
         

        }

        public Domain.SurveyBuilder.Models.Client Create(Domain.SurveyBuilder.Models.Client item)
        {
            var action = Mapper.Map<Repository.Models.Survey.Client>(item);
            try
            {
                Context.Clients.Add(action);
                Context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Delete(Domain.SurveyBuilder.Models.Client item)
        {
            var action = Mapper.Map<Repository.Models.Survey.Client>(item);
            try
            {
                Context.Clients.Remove(action);
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Domain.SurveyBuilder.Models.Client Update(Domain.SurveyBuilder.Models.Client item)
        {
            var action = Mapper.Map<Repository.Models.Survey.Client>(item);
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

        public IQueryable<Domain.SurveyBuilder.Models.Client> GetAll()
        {
            try
            {
                return Context.Clients.AsQueryable().Project().To<Domain.SurveyBuilder.Models.Client>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Domain.SurveyBuilder.Models.Client> FindAll(Expression<Func<Domain.SurveyBuilder.Models.Client, bool>> where = null)
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

        public Domain.SurveyBuilder.Models.Client Get(int id)
        {
            return FindOne(a => a.ClientId == id);
        }

        public Domain.SurveyBuilder.Models.Client FindOne(Expression<Func<Domain.SurveyBuilder.Models.Client, bool>> where = null)
        {
            return FindAll(where).FirstOrDefault();
        }

    }
}

