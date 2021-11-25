using FirtMVC.App.Entities;
using FirtMVC.App.Models;
using FirtMVC.App.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace FirtMVC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly CustomersService customersService;
        private readonly CountriesService countriesService;

        public HomeController(CustomersService customersService
            , CountriesService countriesService, ILogger<HomeController> logger)
        {
            this.customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
            this.countriesService = countriesService ?? throw new ArgumentNullException(nameof(countriesService));

            _logger = logger;
        }

        public IActionResult Name()
        {            
            Customer customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Wael Elkadim"
            };

            ViewBag.CurrentDate = DateTime.Now;
            ViewBag.Customer = customer;

            ViewData["CurrentDate2"] = DateTime.Now;
            ViewData["Customer2"] = customer;
            //return View("~/views/customers/xxy.cshmtl", customer);
            return View("Name2");
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
