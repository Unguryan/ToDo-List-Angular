using Microsoft.AspNetCore.Mvc;

namespace Tasks.Angular.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
