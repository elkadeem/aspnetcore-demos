﻿using FirtMVC.App.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirtMVC.App.Controllers
{
    public class StudentsController : Controller
    {

        public StudentsController()
        {

        }

        //Index search by student name, Update, Delete, Details

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            ViewBag.Message = "Succsseded";
            return View(student);
        }
    }
}
