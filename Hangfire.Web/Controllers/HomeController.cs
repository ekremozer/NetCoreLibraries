using Hangfire.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Hangfire.Web.HingfireJobs;

namespace Hangfire.Web.Controllers
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
            return View();
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

        public IActionResult FireAndForget()
        {
            FireAndForgetJobs.Example();
            return View("Index");
        }

        public IActionResult Delayed()
        {
            DelayedJobs.Example();
            return View("Index");
        }
        public IActionResult Continuations()
        {
            ContinuationsJobs.Example();
            return View("Index");
        }

        public IActionResult Recurring()
        {
            RecurringJobs.Example();
            return View("Index");
        }
    }
}