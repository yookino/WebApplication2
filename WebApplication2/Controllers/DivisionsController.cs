using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(string divisionId, string divisionName)
        {
            TestContext context = new TestContext();
            var divisions = context
                                .Divisions
                                .Where(d => d.DivisionId.ToString().Contains(divisionId)
                                        && d.DivisionName.Contains(divisionName))
                                .ToList();

            return View(divisions);
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
