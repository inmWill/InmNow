using System;
using System.Net.Http;
using System.Web.Http;
using InmNow.API.ViewModels;
using InmNow.Domain.Models;
using InmNow.Service.Interfaces;
using NLog;

namespace InmNow.API.Controllers
{   
    public class InmAbstractsController : BaseController
    {
        readonly IInmAbstractsService _abstractsService;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmAbstractsController(IInmAbstractsService abstractsService)
        {
            _abstractsService = abstractsService;
        }
        // GET api/clientetlsettings
        public IHttpActionResult GetAbstractByIdAsViewModel(int abstractId)
        {
            try
            {
                var abstractModel = _abstractsService.GetAbstractById(abstractId);
                return BuildViewModel<InmAbstractsViewModel>(Request, abstractModel);
            }
            catch (Exception ex)
            {
                Logger.Error("Error retrieveing abstract: {0}", ex.Message);
                return null;
            }

        }

        // GET api/clientetlsettings/Get/5
        public InmAbstract GetAbstractById(int abstractId)
        {
            try
            {
                return _abstractsService.GetAbstractById(abstractId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error retrieveing abstract: {0}", ex.Message);
                return null;
            }
        }

        // POST api/clientetlsettings/Post
        public InmAbstract InsertAbstract([FromBody]InmAbstract value)
        {
            return _abstractsService.CreateAbstract(value);
        }

        // PUT api/clientetlsettings/Put
        public InmAbstract Put([FromBody]InmAbstract value)
        {
            return _abstractsService.UpsertAbstract(value);
            // return _clientETLSettingsRepository.Update(value);
        }

        // DELETE api/clientetlsettings/5
        //public bool Delete(ClientETLSettings value)
        //{
        //   return _abstractsService.Delete(value);
        //}
    }
}
