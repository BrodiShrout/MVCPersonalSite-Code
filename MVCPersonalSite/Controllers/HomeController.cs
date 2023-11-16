using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MVCPersonalSite.Models;
using System.Diagnostics;
using MailKit.Net.Smtp;

namespace MVCPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Languages()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            ViewBag.Project = ProjectViewModel.GetProjects();
            return View();
        }

        public IActionResult PortfolioDetails() => View();
        public IActionResult PortfolioDetails2() => View();
        public IActionResult PortfolioDetails3() => View();
        public IActionResult PortfolioDetails4() => View();
        public IActionResult PortfolioDetails5() => View();
        public IActionResult PortfolioDetails6() => View();
        public IActionResult PortfolioDetails7() => View();
        public IActionResult PortfolioDetails8() => View();


        public IActionResult Resume()
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
    }
}