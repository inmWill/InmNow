using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using InmNow.Email.Interfaces;
using SendGrid;

namespace InmNow.Email.SendGrid
{
    public class InmEmail : IInmEmail
    {
        /* Alternatively, you may store these credentials via your Azure portal
               by clicking CONFIGURE and adding the key/value pairs under "app settings".
               Then, you may access them as follows: 
               var username = System.Environment.GetEnvironmentVariable("SENDGRID_USER"); 
               var pswd = System.Environment.GetEnvironmentVariable("SENDGRID_PASS");
               assuming you named your keys SENDGRID_USER and SENDGRID_PASS */
        private const string Username = "azure_349ac0351027c1230ee266e1d66ee395@azure.com";
        private const string Pswd = "jSyd6W3hb7fqyfS";
        private readonly NetworkCredential _credentials;

        public InmEmail()
        {
            _credentials = new NetworkCredential(Username, Pswd);
        }

        public bool Send()
        {
            
            


            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage {From = new MailAddress("now@inmerge.com")};

            // Add the message properties.

            // Add multiple addresses to the To field.
            var recipients = new List<String>
            {
                @"W Thomas <wthomas@inmerge.com>",
                @"Will Thomas <will.thomas@inmerge.com>"
            };

            myMessage.AddTo(recipients);

            myMessage.Subject = "Testing the SendGrid Library";

            //Add the HTML and Text bodies
            myMessage.Html = "<p>Hello World!</p>";
            myMessage.Text = "Hello World plain text!";

            // Create an Web transport for sending email.
            var transportWeb = new Web(_credentials);

            // Send the email.
            // You can also use the **DeliverAsync** method, which returns an awaitable task.
            transportWeb.Deliver(myMessage);
            return true;
        }

    }
}
