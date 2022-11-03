using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult Random()
        {
            return View();
        }
    }
}
