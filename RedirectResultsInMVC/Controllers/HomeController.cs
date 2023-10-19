using Microsoft.AspNetCore.Mvc;
using RedirectResultsInMVC.Models;
using System.Diagnostics;

namespace RedirectResultsInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Redirect Result in ASP.NET Core MVC
        //public RedirectResult Index()
        //{

        //    //return new RedirectResult("https://dotnettutorials.net");

        //    //Using RedirectResult Helper Method
        //    return Redirect("https://dotnettutorials.net");
        //}

        //RedirectToRouteResult

        //RedirectToActionResult in ASP.NET Core MVC
        //public RedirectToRouteResult Index()
        //{
        //    // Perform some logic
        //    // Redirect to a different route
        //    // You need to specify the Route Name, not the Route Pattern
        //    //return RedirectToRoute("AboutRoute", new { name = "Mukesh Kumar" });

        //    //Redirect to same or different controller
        //    return RedirectToRoute(new { controller = "Home", action = "About", name = "Mukesh Kumar" });
        //}

        //RedirectToActionResult in ASP.NET Core MVC
        public RedirectToActionResult Index()
        {

            // Perform Some Logic
            // Redirect to a different action within the same controller
            // Specifying the Controller name is Optional
            return RedirectToAction("About", "Home", new {name="Mukesh Kumar"});
            //  return RedirectToAction("AboutUs");
        }

        public string About(string name)
        {
            return "Welcome to .Net Tutorials Test " + name;
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