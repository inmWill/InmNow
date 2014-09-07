using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InmNow.Domain.Models;
using InmNow.Logic.Collectives;
using InmNow.Logic.Interfaces;
using InmNow.Repository;
using NLog;

namespace InmNow.WebAPI.Controllers
{   
    public class AbstractsController : ApiController
    {
        readonly IAbstractsCollective _abstractsCollective;

        public AbstractsController(IAbstractsCollective abstractsCollective)
        {
            _abstractsCollective = abstractsCollective;
        }

        // GET api/clientetlsettings
        //public IEnumerable<ClientETLSettings> Get()
        //{
        //    return _clientETLSettingsRepository.GetAll();
        //}

        // GET api/clientetlsettings/Get/5
        public Abstract GetAbstractById(int abstractId)
        {
            return _abstractsCollective.GetAbstractById(abstractId);
        }

        // POST api/clientetlsettings/Post
        public Abstract InsertAbstract([FromBody]Abstract value)
        {
            return _abstractsCollective.CreateAbstract(value);
        }

        // PUT api/clientetlsettings/Put
        public Abstract Put([FromBody]Abstract value)
        {
            return _abstractsCollective.UpsertAbstract(value);
            // return _clientETLSettingsRepository.Update(value);
        }

        // DELETE api/clientetlsettings/5
        //public bool Delete(ClientETLSettings value)
        //{
        //   return _clientETLSettingsRepository.Delete(value);
        //}
    }
}
