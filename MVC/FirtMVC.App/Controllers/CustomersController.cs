using FirtMVC.App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
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
        public CustomersController()
        {

        }
        // GET: CustomersController
        public ActionResult Index()
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
            FillCountries();
            return View();
        }

        private void FillCountries()
        {
            List<Country> countries = new List<Country> {
                new Country(1, "مصر"),
                new Country(2, "السعودية"),
                new Country(3, "الأمارات"),
                new Country(4, "ليبيا"),
            };

            //Option 1 with Selected List Item
            //ViewBag.Countries = new SelectList(countries, "Id", "Name", 2);

            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var country in countries)
            {
                items.Add(new SelectListItem
                {
                    Text = country.Name,
                    Value = country.Id.ToString(),
                    Selected = country.Id == 1
                });
            }
            ViewBag.Countries = items;
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
                    FillCountries();
                    return View(customer);
                }

                customer.Id = Guid.NewGuid();
                Customers.Add(customer);
                TempData["Message"] = "Succeeded";
                return RedirectToAction(nameof(Details), new { customer.Id });
            }
            catch
            {
                FillCountries();
                return View(customer);
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            FillCountries();
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
                    FillCountries();
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
                FillCountries();
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
    }
}
