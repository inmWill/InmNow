using System;
using System.Net.Http;
using System.Web.Http;
using InmNow.API.ViewModels;
using InmNow.Domain.Models;
using InmNow.Service.Interfaces;
using InmNow.Service.Services;
using NLog;

namespace InmNow.API.Controllers
{   
    [Authorize]
    public class InmNotifyController : BaseController
    {
        readonly IUserNotificationService _notifyService;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmNotifyController(IUserNotificationService notifyService)
        {
            _notifyService = notifyService;
        }


        public IHttpActionResult GetAuthAccountInfo()
        {
            var isAuth = User.Identity.IsAuthenticated;
            var userName = User.Identity.Name;

            return Ok("Is user authorized: " + isAuth + " Name: " + userName);

        }


        // GET api/clientetlsettings/Get/5
        public IHttpActionResult SendSuccessEmail()
        {
            try
            {
                if (_notifyService.SendSuccessEmail())
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error sending email: {0}", ex.Message);
                return BadRequest();
            }
        }
    }
}
