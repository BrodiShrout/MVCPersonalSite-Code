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

        public IActionResult PortfolioDetails(int? id)
        {
            return View(ProjectViewModel.GetProjects().FirstOrDefault(x => x.ID == id));
        }


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