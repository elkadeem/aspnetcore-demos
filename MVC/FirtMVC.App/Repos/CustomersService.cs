using FirtMVC.App.Entities;
using FirtMVC.App.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtMVC.App.Repos
{
    public class CustomersService
    {
        private readonly IRepository repository;
        private readonly CountriesService countriesService;
        public Guid _Id;
        public CustomersService(IRepository repository, CountriesService countriesService)

        {
            this.repository = repository;
            this.countriesService = countriesService ?? throw new ArgumentNullException(nameof(countriesService));
            _Id = Guid.NewGuid();
        }

        public IRepository Repository => repository;

        public List<Customer> GetAll()
        {
            return null;
        }

        Customer GetCustomer(Guid customer)
        {
            return null;
        }

    }
}
