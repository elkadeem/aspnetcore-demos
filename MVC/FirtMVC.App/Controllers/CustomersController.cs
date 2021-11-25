using FirtMVC.App.Entities;
using FirtMVC.App.Repos;
using FirtMVC.App.Sample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace FirtMVC.App.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> Customers = new List<Customer>
        {
            new Customer{ 
                Id = Guid.NewGuid(),
                Birthdate = new DateTime(1999, 1, 1),
                Email = "Customer1@email.com",
                IsActive = true,
                Name = "Customer 1",
                Phone = "122333",
                Country = "EG"
            },
            new Customer{
                Id = Guid.NewGuid(),
                Birthdate = new DateTime(1999, 1, 3),
                Email = "Customer2@email.com",
                IsActive = true,
                Name = "Customer 2",
                Phone = "32422",
                Country = "EG"
            },
            new Customer{
                Id = Guid.NewGuid(),
                Birthdate = new DateTime(1999, 1, 3),
                Email = "Customer3@email.com",
                IsActive = true,
                Name = "Customer 2",
                Phone = "243423432",
                Country = "EG"
            },
        };
        private readonly CustomersService customersService;
        private readonly CountriesService countriesService;

        public CustomersController()
        {
            SqlConnection connection = new SqlConnection("Connection string");
            IRepository repository = new SqlRepository(connection);
            this.countriesService = new CountriesService(repository);
            this.customersService = new CustomersService(repository, countriesService);
        }
        // GET: CustomersController
        public IActionResult Index()
        {
            var items =  Customers
                .OrderBy(c => c.Name)
                .ToList();

            return View(items);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(Guid id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);
            
            if (customer == null)
                return NotFound();

            return View(customer);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            Customer model = new Customer();
            model.Countries = FillCountries();
            return View(model);
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            
            try
            {               
                if (customer.Tags == null || customer.Tags.Count == 0)
                {
                    ModelState.AddModelError("Tags", "يجب أختيار تاج واحد علي الأقل.");
                }

                if (customer.Birthdate > DateTime.Today.AddYears(-18))
                {
                    ModelState.AddModelError("Birthdate", "يجب أن تكون أكبر من 18 عام");
                }

                if(Customers.Any(c => c.Email== customer.Email))
                {
                    ModelState.AddModelError("", "الإيميل مكرر");
                }

                if (!ModelState.IsValid)   // If(Page.IsValid)
                {
                    customer.Countries = FillCountries();
                    return View(customer);
                }

                customer.Id = Guid.NewGuid();
                Customers.Add(customer);
                TempData["Message"] = "Succeeded";
                //Fire Event Country Create
                return RedirectToAction(nameof(Details), new { customer.Id });
            }
            catch
            {
                customer.Countries = FillCountries();
                return View(customer);
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            customer.Countries = FillCountries();
            return View(customer);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, [Bind("Name", "Phone", "Birthdate", "Country", "Tags")][FromBody]Customer customer)
        {
            try
            {
                if (!ModelState.IsValid)   // If(Page.IsValid)
                {
                    customer.Countries = FillCountries();
                    return View(customer);
                }

                var item = Customers.FirstOrDefault(c => c.Id == id);

                if (item == null)
                    return NotFound();

                item.Birthdate = customer.Birthdate;
                item.Country = customer.Country;
                //item.Email = customer.Email;
                //item.IsActive = customer.IsActive;
                item.Name = customer.Name;
                item.Phone = customer.Phone;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                customer.Countries = FillCountries();
                return View(customer);
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Customer customer)
        {
            try
            {
                var item = Customers.FirstOrDefault(c => c.Id == id);

                if (item == null)
                    return NotFound();

                Customers.Remove(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(customer);
            }
        }

        //Get: Customers/Cities?countryId={countryId}
        public IActionResult Cities(int countryId)
        {
            return NotFound();
            //ToDo: Get Data from datastore
            List<City> cities = new List<City>();
            for (int i = 1; i < 10; i++)
            {
                cities.Add(new City(i, $"Country-{countryId} City-{i}"));
            }

            return Json(cities);
        }
        private List<SelectListItem> FillCountries()
        {
            List<Country> countries = countriesService.GetAll();

            //List<SelectListItem> items = new List<SelectListItem>();
            //foreach (var country in countries)
            //{
            //    items.Add(new SelectListItem
            //    {
            //        Text = country.Name,
            //        Value = country.Id.ToString(),
            //        Selected = country.Id == 1
            //    });
            //}

            return countries.Select(country => new SelectListItem
            {
                Text = country.Name,
                Value = country.Id.ToString(),
                Selected = country.Id == 1
            }).ToList();
        }
    }
}
