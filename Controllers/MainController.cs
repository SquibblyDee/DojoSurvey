using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult Result(string Name, string Location, string FavLang, string Comment="")
        {
            return View();
        }
    }
}
