using FirtMVC.App.Entities;
using FirtMVC.App.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtMVC.App.Repos
{
    public class CountriesService
    {
        private readonly IRepository repository;
        public Guid _Id;
        public CountriesService(IRepository repository)
        {
            this.repository = repository;
            _Id = Guid.NewGuid();
        }

        public List<Country> GetAll()
        {
            return repository.Countries();
        }
    }
}
