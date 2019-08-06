using Microsoft.AspNetCore.Mvc;
using PortfolioAplication.Models;
using System.Diagnostics;
using System.Linq;


namespace PortfolioAplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly WorkContext context;

        public HomeController(WorkContext workContext)
        {
            context = workContext;
        }
        [Route("[controller]/test")]
        public IActionResult Index()
        {

            return View(context.Works.ToList());
        }

        public IActionResult CreateWork()
        {
            return View();
        }

        public IActionResult Works()
        {
            return View(context.Works.ToList());
        }
        [HttpPost]
        public IActionResult PostWork(Work work)
        {
            context.Works.AddAsync(work);
            context.SaveChangesAsync();
            return RedirectToActionPermanent("Works");
        }

        [Route("")]
        public IActionResult Indext()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
