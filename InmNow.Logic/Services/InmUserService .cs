using System;
using System.Linq;
using InmNow.Domain.Models;
using InmNow.Repository.Repositories;
using InmNow.Service.Interfaces;
using NLog;


namespace InmNow.Service.Services
{

    public class InmUserService : IInmUserService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmUserRepository InmUserRepository;

        public InmUserService()
        {
            InmUserRepository = new InmUserRepository();
        }

        public IQueryable<InmUser> GetAll()
        {
            try
            {
                return InmUserRepository.FindAll();
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Users: {0}", ex.Message);
                return null;
            }
        }

        public InmUser GetByUserName(string userName)
        {
            try
            {
                return InmUserRepository.FindOne(u => u.UserName == userName);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Sessions: {0}", ex.Message);
                return null;
            }
        }

        public InmUser CreateUser(InmUser newUser)
        {
            try
            {
                return InmUserRepository.Create(newUser);

            }
            catch (Exception ex)
            {
                Logger.Error("Error Creating Uesr: {0}", ex.Message);
                return null;
            }

        }

        public InmUser UpsertUser(InmUser inmUserUpdate)
        {
            try
            {
                var exists = InmUserRepository.GetByUserName(inmUserUpdate.UserName);
                if (exists == null)
                    InmUserRepository.Create(inmUserUpdate);
                else
                    InmUserRepository.Update(inmUserUpdate);

                return inmUserUpdate;
            }
            catch (Exception ex)
            {
                Logger.Error("Error Upserting User: {0}", ex.Message);
                return null;
            }
        }
    }
}