using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using InmNow.API.ViewModels;
using InmNow.Domain.Models;
using InmNow.Service.Interfaces;
using NLog;

namespace InmNow.API.Controllers
{
    public class InmUserController : BaseController
    {
        private readonly IInmUserService _userService;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmUserController(IInmUserService userService)
        {
            _userService = userService;
        }

        // GET api/InmUser/GetAll
        [Authorize]
        public IHttpActionResult GetAll()
        {
            try
            {
                var userModel = _userService.GetAll();
                return BuildViewModel<IQueryable<InmUserViewModel>>(Request, userModel);
            }
            catch (Exception ex)
            {
                Logger.Error("Error retrieveing abstract: {0}", ex.Message);
                return null;
            }

        }

        // GET api/InmUser/GetUser?userName=NAME
        [Authorize]
        public IHttpActionResult GetUser(string userName)
        {
            try
            {
                var abstractModel = _userService.GetByUserName(userName);
                return BuildViewModel<InmAbstractsViewModel>(Request, abstractModel);
            }
            catch (Exception ex)
            {
                Logger.Error("Error retrieveing abstract: {0}", ex.Message);
                return null;
            }

        }

        // POST api/clientetlsettings/Post
        public InmUser InsertUser([FromBody] InmUser value)
        {
            return _userService.CreateUser(value);
        }

        // PUT api/clientetlsettings/Put
        public InmUser Put([FromBody] InmUser value)
        {
            return _userService.UpsertUser(value);
            // return _clientETLSettingsRepository.Update(value);
        }

    }
}
