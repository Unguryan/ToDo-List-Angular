using Microsoft.AspNetCore.Mvc;

namespace Tasks.Angular.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
