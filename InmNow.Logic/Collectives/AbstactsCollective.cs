using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmNow.Logic.Interfaces;
using InmNow.Domain.Models;
using InmNow.Repository.Repositories;
using NLog;


namespace InmNow.Logic.Collectives
{

    public class AbstactsCollective : IAbstractsCollective
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public AbstractRepository AbstractRepository;

        public AbstactsCollective()
        {
            AbstractRepository = new AbstractRepository();
        }

        public IQueryable<Abstract> GetAllAbstractsForSession(int sessionId)
        {
            try
            {
                return AbstractRepository.FindAll(a => a.SessionId == sessionId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Sessions: {0}", ex.Message);
                return null;
            }
        }

        public Abstract GetAbstractById(int abstractId)
        {
            try
            {
                return AbstractRepository.FindOne(a => a.AbstractId == abstractId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Abstract: {0}", ex.Message);
                return null;
            }
        }

        public Abstract GetAbstractByLognumber(int lognumber)
        {
            try
            {
                return AbstractRepository.FindOne(a => a.Lognumber == lognumber);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Abstract: {0}", ex.Message);
                return null;
            }
        }

        public Abstract CreateAbstract(Abstract newAbstract)
        {
            try
            {
                return AbstractRepository.Create(newAbstract);
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error Creating Abstract: {0}", ex.Message);
                return null;
            }

        }

        public Abstract UpsertAbstract(Abstract abstractUpdate)
        {
            try
            {
                var exists = AbstractRepository.Get(abstractUpdate.Lognumber);
                if (exists == null)
                    AbstractRepository.Create(abstractUpdate);
                else
                    AbstractRepository.Update(abstractUpdate);

                return abstractUpdate;
            }
            catch (Exception ex)
            {
                Logger.Error("Error Upserting Abstract: {0}", ex.Message);
                return null;
            }
        }
    }
}