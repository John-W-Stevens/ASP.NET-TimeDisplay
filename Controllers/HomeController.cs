using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeDisplay.Controllers
{
    public class HomeController : Controller
    {
        // GET Time-display
        [HttpGet("")]
        public IActionResult Index()
        {
            // use ViewBag

            //ViewBag.Time = "11:36 AM";
            ViewBag.Time = DateTime.Now.ToString("h:mm tt");
            //ViewBag.Date = "Oct 26, 2013";
            ViewBag.Date = DateTime.Now.ToString("MMM dd, yyyy");
            return View();
        }
    }
}
