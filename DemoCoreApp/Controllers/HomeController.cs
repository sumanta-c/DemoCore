using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoCoreApp.Models;

namespace DemoCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            calc objCalc = new calc();
            return View(objCalc);
        }

        [HttpPost]
        public IActionResult Index(calc objParamCalc)
        {
            calc objCalc = new calc();
            switch(objParamCalc.strOperator)
            {
                case "add" :
                    objCalc.Add(objParamCalc.operand1,objParamCalc.operand2);
                    break;
                case "sub" :
                    objCalc.Subtract(objParamCalc.operand1,objParamCalc.operand2);
                    break;
            }

            return View(objCalc);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
