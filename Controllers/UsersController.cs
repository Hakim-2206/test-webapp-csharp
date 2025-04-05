using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebSite.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
