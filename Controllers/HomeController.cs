using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResumePorfolio.Models;

using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace ResumePorfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
    //--------------------------------------------------------
    //--------------------------------------------------------
        public IActionResult Index()
        {
            return View();
        }
    //--------------------------------------------------------
    //--------------------------------------------------------
        [HttpGet("home")]
        public IActionResult HomePage()
        {
            return View();
        }
    //--------------------------------------------------------
        [HttpGet("projects")]
        public IActionResult ProjectPage()
        {
            return View();
        }
    //--------------------------------------------------------
        [HttpGet("resume")]
        public IActionResult ResumePage()
        {
            return View();
        }
    //--------------------------------------------------------
        [HttpGet("features")]
        public IActionResult FeaturePage()
        {
            return View();
        }
    //--------------------------------------------------------
    //--------------------------------------------------------
    //--------------------------------------------------------






    //--------------------------------------------------------
    //--------------------------------------------------------
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
