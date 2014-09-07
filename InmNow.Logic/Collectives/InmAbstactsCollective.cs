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

    public class InmAbstractsCollective : IInmAbstractsCollective
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmAbstractRepository InmAbstractRepository;

        public InmAbstractsCollective()
        {
            InmAbstractRepository = new InmAbstractRepository();
        }

        public IQueryable<InmAbstract> GetAllAbstractsForSession(int sessionId)
        {
            try
            {
                return InmAbstractRepository.FindAll(a => a.SessionId == sessionId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Sessions: {0}", ex.Message);
                return null;
            }
        }

        public InmAbstract GetAbstractById(int abstractId)
        {
            try
            {
                return InmAbstractRepository.FindOne(a => a.InmAbstractId == abstractId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Abstract: {0}", ex.Message);
                return null;
            }
        }

        public InmAbstract GetAbstractByLognumber(int lognumber)
        {
            try
            {
                return InmAbstractRepository.FindOne(a => a.Lognumber == lognumber);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Abstract: {0}", ex.Message);
                return null;
            }
        }

        public InmAbstract CreateAbstract(InmAbstract newAbstract)
        {
            try
            {
                return InmAbstractRepository.Create(newAbstract);
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error Creating Abstract: {0}", ex.Message);
                return null;
            }

        }

        public InmAbstract UpsertAbstract(InmAbstract abstractUpdate)
        {
            try
            {
                var exists = InmAbstractRepository.Get(abstractUpdate.Lognumber);
                if (exists == null)
                    InmAbstractRepository.Create(abstractUpdate);
                else
                    InmAbstractRepository.Update(abstractUpdate);

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