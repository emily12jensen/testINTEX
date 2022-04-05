using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testINTEX.Models;

namespace testINTEX.Controllers
{
    public class HomeController : Controller
    {
        private RDSContext __context { get; set; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(RDSContext temp)
        {
            __context = temp;
        }

        public IActionResult Index()
        {
            var blah = __context.crashes.ToList();
            return View(blah);
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
