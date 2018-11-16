using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using dotenv.net;

namespace smsverifylibrary
{
    interface ISmSSend
    {
        string PhoneNumber(string CustomerPhoneNumber);
    }

     public class VerifySmS
    {
            public void VerifyText(string CustomerPhoneNumber)
            {
                
                DotEnv.Config();
                string accountSID = System.Environment.GetEnvironmentVariable("TWILIO_SID");
                string authToken = System.Environment.GetEnvironmentVariable("TWILIO_AUTHTOKEN");
                string TwilioNumber = System.Environment.GetEnvironmentVariable("TWILIO_PHONE");

                try
                {
                    
                    TwilioClient.Init(accountSID, authToken);
                    

                    var message = MessageResource.Create(
                        body: "Would you like to recieve SMS notifications? Reply Yes or No, Reply STOP at any time " 
                                + "to disable text notifications",
                        from: new Twilio.Types.PhoneNumber(TwilioNumber),
                        to: new Twilio.Types.PhoneNumber(CustomerPhoneNumber)
                    );
                    //Use Account Sid for testing to make sure the message was sent
                    Console.WriteLine(message.Sid);
                    Console.WriteLine(message.AccountSid);
                }
                catch(Exception exp)
                {
                    Console.Error.WriteLine("Error:" + exp.Message + Environment.NewLine + " " + exp.StackTrace);
                }
                    
                }
    }
     public class NotifySmS
    {
            public void VerifyText(string CustomerPhoneNumber, string TextBody)
            {

                string accountSID = System.Environment.GetEnvironmentVariable("TWILIO_SID");
                string authToken = System.Environment.GetEnvironmentVariable("TWILIO_AUTHTOKEN");
                string TwilioNumber = System.Environment.GetEnvironmentVariable("TWILIO_PHONE");

                try
                {
                    
                    TwilioClient.Init(accountSID, authToken);
                    

                    var message = MessageResource.Create(
                        body: TextBody,
                        from: new Twilio.Types.PhoneNumber(TwilioNumber),
                        to: new Twilio.Types.PhoneNumber(CustomerPhoneNumber)
                    );
                    //Use Account Sid for testing to make sure the message was sent
                    Console.WriteLine(message.Sid);
                    Console.WriteLine(message.AccountSid);
                }
                catch(Exception exp)
                {
                    Console.Error.WriteLine("Error:" + exp.Message + Environment.NewLine + " " + exp.StackTrace);
                }
                
            }
    }
}

    

