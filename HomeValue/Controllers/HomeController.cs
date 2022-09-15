using HomeValue.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllElements elements;

        public HomeController(IAllElements elements)
        {
            this.elements = elements;
        }
        public IActionResult Index()
        {
            return View(elements.Elements);
        }
        public IActionResult Distributor(string name)
        {
            if (name == "фундамент")
                return View("Concrete");
            else if (name == "стены")
                return View("Wall");
            else
                return View("Roof");
        }
    }
}
