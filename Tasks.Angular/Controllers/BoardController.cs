using Microsoft.AspNetCore.Mvc;

namespace Tasks.Angular.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
