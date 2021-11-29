using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo
{
    class User
    {
        public int Id { get; set; }

        public List<Role> Roles { get; set; }
    }
}
