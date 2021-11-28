using FirtMVC.App.Controllers;
using FirtMVC.App.Repos;
using FirtMVC.App.Sample;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FirtMVC.App
{
    public class Testing
    {
        public void Test()
        {
            SqlConnection connection = new SqlConnection("Connection string");

            IRepository repository = new SqlRepository(connection);

            CountriesService countriesService
                = new CountriesService(repository);

            CustomersService customersService
                = new CustomersService(repository, countriesService);

            //CustomersController customersController 
            //    = new CustomersController(new Entities.DemoDbContext());
        }
    }
}
