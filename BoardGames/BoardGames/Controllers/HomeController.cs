using Microsoft.AspNetCore.Mvc;

namespace BoardGames.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}