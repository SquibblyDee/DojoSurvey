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

        [HttpPost("result")]
        public IActionResult Result(FormData data)
        {
            FormData newForm = new FormData()
            {
                Name = data.Name,
                Location = data.Location,
                Language = data.Language,
                Comment = data.Comment
            };
    
            return View(newForm);
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
