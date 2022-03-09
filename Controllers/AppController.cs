using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.ViewModels;

namespace TigerTix.Web.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}
