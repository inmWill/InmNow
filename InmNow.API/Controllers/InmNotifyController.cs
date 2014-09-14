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
    public class InmNotifyController : BaseController
    {
        readonly IUserNotificationService _notifyService;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InmNotifyController(IUserNotificationService notifyService)
        {
            _notifyService = notifyService;
        }     

        // GET api/clientetlsettings/Get/5
        public IHttpActionResult GetSendSuccessEmail()
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
