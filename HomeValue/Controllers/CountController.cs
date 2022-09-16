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
            var el = elements.Elements.FirstOrDefault(p => p.Id == 1);
            float pice = el.JobPrice + el.MaterialPrice;
            estimate.AddEstimeteItem(param, pice);
            return RedirectToAction("IndexCount");
        }
        public IActionResult WallValue(Parameter param)
        {
            var el = elements.Elements.FirstOrDefault(p => p.Id == 1);
            float pice = el.JobPrice + el.MaterialPrice;
            estimate.AddEstimeteItem(param, pice);
            return RedirectToAction("IndexCount");
        }
        public IActionResult RoofValue(Parameter param)
        {
            var el = elements.Elements.FirstOrDefault(p => p.Id == 1);
            float pice = el.JobPrice + el.MaterialPrice;
            estimate.AddEstimeteItem(param, pice);
            return RedirectToAction("IndexCount");
        }
    }
}
