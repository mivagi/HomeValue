using HomeValue.Data.Interfaces;
using HomeValue.Data.Models;
using HomeValue.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Controllers
{
    //В контроллере производяться вычисления и переход на страницу со сметой
    public class CountController : Controller
    {
        private readonly IAllElements elements;
        private readonly Estimate estimate;

        public CountController(IAllElements elements, Estimate estimate)
        {
            this.elements = elements;
            this.estimate = estimate;
        }
        public IActionResult IndexCount()
        {
            return View(estimate);
        }
        public IActionResult ConcreteValue(Parameter param)
        {
            estimate.AddEstimeteItem(param);
            return RedirectToAction("IndexCount");
        }
        public IActionResult WallValue(Parameter param)
        {
            estimate.AddEstimeteItem(param);
            return RedirectToAction("IndexCount");
        }
        public IActionResult RoofValue(Parameter param)
        {
            estimate.AddEstimeteItem(param);
            return RedirectToAction("IndexCount");
        }
        public IActionResult Delete(string name)
        {
            estimate.Delete(name);
            return RedirectToAction("IndexCount");
        }
    }
}
