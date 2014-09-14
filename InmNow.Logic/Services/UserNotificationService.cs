using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmNow.Email;
using InmNow.Email.SendGrid;
using InmNow.Service.Interfaces;
using NLog;

namespace InmNow.Service.Services
{
    public class UserNotificationServiceService : IUserNotificationService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public InmEmail inmEmail;

        public bool SendSuccessEmail()
        {
            inmEmail = new InmEmail();
            return inmEmail.Send();
        }

        public bool SendFailureEmail()
        {
            return inmEmail.Send();
        }


    }
}
