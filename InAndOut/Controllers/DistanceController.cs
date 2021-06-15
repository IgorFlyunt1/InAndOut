using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class DistanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SimpleDistance()
        {
            return View();
        }

        public IActionResult MultipleDistance()
        {
            return View();
        }


    }
}
