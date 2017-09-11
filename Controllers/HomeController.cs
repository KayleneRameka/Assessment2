using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment2.Models;

namespace Assessment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Title"] = "Profile";
            return View();
        }

        public IActionResult Portfolio()
        {
            ViewData["Message"] = "Your description";
            ViewData["Title"] = "Portfolio";
           return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewData["Title"] = "Contact";
            return View();
        }

        public IActionResult Blog()
        {
           ViewData["Message"] = "description";
           ViewData["Title"] = "Blog"; 
           return View();
        }

        public IActionResult Media()
        {
           ViewData["Message"] = "Description";
           ViewData["Title"] = "Media Gallery"; 
           return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
