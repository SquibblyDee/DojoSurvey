using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string username, string location, string favlang, string comment)
        {
            string defName = "John Doe";
            if(username == null)
            {
                ViewBag.Name=defName;
                ViewBag.Location=location;
                ViewBag.FavLang=favlang;
                ViewBag.Comment=comment;
            }
            else
            {
                ViewBag.Name=username;
                ViewBag.Location=location;
                ViewBag.FavLang=favlang;
                ViewBag.Comment=comment;
            }
    
            return View();
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
