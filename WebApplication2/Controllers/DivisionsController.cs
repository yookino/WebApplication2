using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DivisionsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            TestContext context = new TestContext();

            // Select * FROM Divisions sql command
            var divisions = context.Divisions.ToList(); //Entity Framework

            return Json(divisions);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Divisions divisions)
        {
            TestContext context = new TestContext();
            context.Divisions.Add(divisions);
            context.SaveChanges();

            return Json(divisions);
        }
    }
}
