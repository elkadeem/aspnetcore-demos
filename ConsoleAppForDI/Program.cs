using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ConsoleAppForDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //With Dependance Inject

            Console.WriteLine("============== With DI ===================================");
            
            //Type Registerations
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IMailService, MailService>();
            services.AddTransient<IMailService, SMSService>();

            services.AddTransient<StudentService>();
            services.AddTransient<SMTPService>();

            var serviceProvider3 = services.BuildServiceProvider();

            var notificationService = serviceProvider3.GetServices<IMailService>();
            //Exerices ??????????????????????????????????????????????????????????????????????
            //Resolve Types
            var studentService4 =  serviceProvider3.GetService<StudentService>();
            studentService4.Register();
            studentService4.ShowResult();

            Console.WriteLine("============== Without DI ===================================");
            // Without DI
            SMTPService sMTPService = new SMTPService();
            MailService mailService1 = new MailService(sMTPService);
            mailService1.Send();

            StudentService studentService2 = new StudentService(new IMailService[] { mailService1, new SMSService() });
            studentService2.Register();

            studentService2.ShowResult();

        }
    }
}
