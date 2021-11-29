using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo
{
    public class Role
    {
        public int Id { get; set; }

        public List<User> Users { get; set; }
    }
}
