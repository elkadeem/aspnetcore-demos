using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForDI
{
    public class MailService : IMailService
    {
        private readonly SMTPService sMTPService;

        public MailService(SMTPService sMTPService)
        {
            if (sMTPService is null)
            {
                throw new ArgumentNullException(nameof(sMTPService));
            }

            this.sMTPService = sMTPService;
        }
        public void Send()
        {
            Console.WriteLine("Send Email");
        }
    }
}
