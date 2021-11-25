using FirtMVC.App.Entities;
using System;
using System.Collections.Generic;

namespace FirtMVC.App.Sample
{
    public interface IRepository
    {
        List<Country> Countries();

        List<Customer> GetCustomers();

        Customer GetCustomer(Guid customer);
    }
}
