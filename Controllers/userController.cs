using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraftPOE.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
