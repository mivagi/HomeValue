using HomeValue.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Controllers
{
    //Контроллер позволяет выбрать стоимость чего расчитать
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
            {
                var el = elements.Elements.FirstOrDefault(n => n.Name == name);
                return View("Concrete", el);
            }
            else if (name == "стены")
            {
                var el = elements.Elements.FirstOrDefault(n => n.Name == name);
                return View("Wall", el);
            }
            else
            {
                var el = elements.Elements.FirstOrDefault(n => n.Name == name);
                return View("Roof", el);
            }
                
        }
    }
}
