using FirtMVC.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtMVC.App.Sample
{
    public class OracleRepository : IRepository
    {
        public List<Country> Countries()
        {
            return new List<Country> {
                new Country(1, "مصر"),
                new Country(2, "السعودية"),
                new Country(3, "الأمارات"),
                new Country(4, "ليبيا"),
            };
        }

        public Customer GetCustomer(Guid customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
