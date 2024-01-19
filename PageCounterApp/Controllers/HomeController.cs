using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services; // Make sure to include the namespace for your service

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageCounterService _pageCounterService;

        // Inject the page counter service into the constructor
        public HomeController(IPageCounterService pageCounterService)
        {
            _pageCounterService = pageCounterService;
        }

        public IActionResult Index()
        {
            // Use the service to increment the page count for "Home"
            var count = _pageCounterService.IncrementPageCount("Home");
            // Pass the count to the view
            return View(count);
        }

        // Add another action for the OtherPage
        public IActionResult OtherPage()
        {
            // Use the service to increment the page count for "OtherPage"
            var count = _pageCounterService.IncrementPageCount("OtherPage");
            // Pass the count to the view
            return View(count);
        }
    }
}