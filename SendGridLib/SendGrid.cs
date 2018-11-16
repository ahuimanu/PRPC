using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using dotenv.net;

namespace SendGridLib
{
        interface ISMTP
        {
            string EmailAddress(string ConfEmail);
        }

        public class EmailConf
        {
            public void VerifyEmail(string ConfEmail)
            {
            Execute().Wait();

             async Task Execute()
            {
            DotEnv.Config();
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress ("troyreeves2@gmail.com", "Troy Reeves"));
            msg.AddTo(new EmailAddress("troyreeves2@gmail.com", "tray way"));
            msg.SetTemplateId("d-c99a05d84f8649a9a72ea35ae78b20b4");
            //var from = new EmailAddress("troyreeves2@gmail.com", "Example User");
            //var subject = "Welcome To SendGrid";
            //var to = new EmailAddress("troyreeves2@gmail.com", "Example User");
            //var plainTextContent = "and easy to do anywhere, even with C#";
            //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            }
           
            }
        }        
    }
