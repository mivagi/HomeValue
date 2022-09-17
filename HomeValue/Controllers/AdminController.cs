using HomeValue.Data.Interfaces;
using HomeValue.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAllElements elements;

        public AdminController(IAllElements elements)
        {
            this.elements = elements;
        }
        public IActionResult IndexAdmin()
        {
            return View(elements.Elements);
        }
        public IActionResult Edit(int id)
        {
            return View(elements.Elements.FirstOrDefault(i => i.Id == id));
        }
        [HttpPost]
        public IActionResult Edit(Element element)
        {
            elements.EditElement(element);
            return RedirectToAction("IndexAdmin");
        }
    }
}
