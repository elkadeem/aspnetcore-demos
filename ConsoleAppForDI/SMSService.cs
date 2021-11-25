using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForDI
{
    public class SMSService : IMailService
    {
        public void Send()
        {
            Console.WriteLine("Send SMS");
        }
    }
}
