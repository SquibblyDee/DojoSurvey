using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        ////This takes our form data and places it into a new instace of our FormData model named data.
        [HttpPost("result")]
        public IActionResult Result(FormData data)
        {
            return View(data);
        }

        public IActionResult Result(string location, string favlang)
        {
            string username="John";
            string comment="2Cool4U";
            ViewBag.Name=username;
            ViewBag.Location=location;
            ViewBag.FavLang=favlang;
            ViewBag.Comment=comment;
            Console.WriteLine("WE IN HERRRRRRRRRRRRRRRRRREEEEEEEEEEEEEEEEEEEEEEE");
            return View();
        }
    }
}
