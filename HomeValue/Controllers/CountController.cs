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
        
    }
}
