using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult Random(int number, int random)
        {
            if (number != random)
            {
                ViewBag.Msg = Models.Guess.deRandom();
                return View();
            }
            else
            {
                ViewBag.Msg = "Enter a number please!";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Random()
        {
            return View();
        }
    }
}
