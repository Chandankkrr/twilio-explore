using System;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace twilioExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TwilioClient.Init(
                "accountSid",
                "authToken"
            );

            MessageResource.Create(
                to: new PhoneNumber("XXXX XXX XXX"),
                from: new PhoneNumber("XXXX XXX XXX"),
                body: "Hello from c#"
            );

            Console.ReadLine();
        }
    }
}
