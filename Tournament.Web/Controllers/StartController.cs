using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tournament.Web.Models;

namespace Tournament.Web.Controllers
{
    public class StartController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("Legal")]
        public IActionResult Legal()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("SignUp")]
        public IActionResult SignUp()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
