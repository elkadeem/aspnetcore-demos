using FirtMVC.App.Entities;
using FirtMVC.App.Models;
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
        private readonly DemoDbContext demoDbContext;

        public CustomersController(DemoDbContext demoDbContext, CountriesService countriesService)
        {
            this.demoDbContext = demoDbContext ?? throw new ArgumentNullException(nameof(demoDbContext));
            this.countriesService = countriesService;
        }
        // GET: CustomersController
        public IActionResult Index()
        {
            var customers = demoDbContext.Customers.OrderBy(c => c.Name)
                .ToList();

            return View(customers);
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
            CustomerViewModel model = new CustomerViewModel();
            model.Countries = FillCountries();
            return View(model);
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel model)
        {
            
            try
            {               
                if (model.Tags == null || model.Tags.Count == 0)
                {
                    ModelState.AddModelError("Tags", "يجب أختيار تاج واحد علي الأقل.");
                }

                if (model.Customer.Birthdate > DateTime.Today.AddYears(-18))
                {
                    ModelState.AddModelError("Birthdate", "يجب أن تكون أكبر من 18 عام");
                }

                if(Customers.Any(c => c.Email== model.Customer.Email))
                {
                    ModelState.AddModelError("", "الإيميل مكرر");
                }

                if (!ModelState.IsValid)   // If(Page.IsValid)
                {
                    model.Countries = FillCountries();
                    return View(model);
                }

                model.Customer.Tags = string.Join(";", model.Tags);
                demoDbContext.Customers.Add(model.Customer);
                demoDbContext.SaveChanges();

                TempData["Message"] = "Succeeded";
                //Fire Event Country Create
                return RedirectToAction(nameof(Details), new { model.Customer.Id });
            }
            catch
            {
                model.Countries = FillCountries();
                return View(model);
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            CustomerViewModel model = new CustomerViewModel() { Customer = customer };
            model.Tags = customer.Tags.Split(";").ToList();
            model.Countries = FillCountries(); 
            return View(model);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, CustomerViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)   // If(Page.IsValid)
                {
                    model.Countries = FillCountries();
                    return View(model);
                }

                var item = demoDbContext.Customers.FirstOrDefault(c => c.Id == id);

                if (item == null)
                    return NotFound();

                item.Birthdate = model.Customer.Birthdate;
                item.Country = model.Customer.Country;
                item.Email = model.Customer.Email;
                item.IsActive = model.Customer.IsActive;
                item.Name = model.Customer.Name;
                item.Phone = model.Customer.Phone;
                item.Tags = string.Join(";", model.Tags);

                demoDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                model.Countries = FillCountries();
                return View(model);
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
                var item = demoDbContext.Customers.FirstOrDefault(c => c.Id == id);

                if (item == null)
                    return NotFound();

                demoDbContext.Customers.Remove(item);
                demoDbContext.SaveChanges();
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
