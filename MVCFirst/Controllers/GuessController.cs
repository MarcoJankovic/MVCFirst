using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult GuessCheck(int guess, bool go)
        {
            if (guess != 0)
            {
                ViewBag.Msg = Models.Guess.RandomNum(guess, go);
                return View();
            }
            else
            {
                ViewBag.Msg = "Provide a number!";
                return View();
            }
        }

        [HttpGet]
        public IActionResult GuessCheck()
        {
            return View();
        }
    }
}
