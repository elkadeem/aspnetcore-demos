using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FirtMVC.App.Controllers
{
    public class ViewDataSampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.CurrentDate = DateTime.Now;
            ViewBag.Name2 = "Wael";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection formCollections)
        {
            ViewBag.CurrentDate = DateTime.Now;
            ViewBag.Name = "Wael";

            TempData["CurrentDate"] = DateTime.Now;
            TempData["Name"] = "Wael";
            return RedirectToAction(nameof(Index));
        }
    }
}
