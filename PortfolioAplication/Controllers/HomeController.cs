using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioAplication.Models;
using PortfolioAplication.Models;

namespace PortfolioAplication.Controllers
{
    public class HomeController : Controller
    {

        private WorkContext db;
        public HomeController(WorkContext context)
        {
            db = context;
        }
        [Route("[controller]/test")]
        public IActionResult Index()
        {
            
            return View(db.Works.ToArray());
        }

        public IActionResult CreateWork()
        {
            return View();
        }

        public IActionResult Works()
        {
            return View(db.Works.ToList());
        }
        [HttpPost]
        public IActionResult PostWork(Work work)
        {
            db.Works.AddAsync(work);
            db.SaveChangesAsync();
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
