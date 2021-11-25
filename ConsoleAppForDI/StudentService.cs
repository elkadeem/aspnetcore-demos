using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForDI
{
    public class StudentService
    {
        IMailService[] _mailService;
        public StudentService(IMailService[] mailService)
        {
            _mailService = mailService;
        }
        public void Register()
        {
            //register

            foreach (var item in _mailService)
            {
                item.Send();
            }
            
        }

        public void ShowResult()
        {
            //Get Result

            //Send By mail            
            foreach (var item in _mailService)
            {
                item.Send();
            }
        }
    }
}
