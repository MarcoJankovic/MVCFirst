using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFirst.Models;


namespace MVCFirst.Controllers
{
    public class GuessController : Controller
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public GuessController(IHttpContextAccessor httpContextAccessor) // Dependency Injection
        {
            _HttpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult GuessCheck()
        {
            var number = HttpContext.Session.GetString("model");
            if (number == null)
            {
                var model = new Guess();
                model.RandomNum();

                HttpContext.Session.SetString("model", model.Number.ToString());
            }

            return View(new Message());
        }

        [HttpPost]
        public IActionResult GuessCheck(int guess)
        {
            var session = HttpContext.Session.GetString("model");
            if (session == null)
            {
                return View(new Message() { Value = Messages.TheGuess });
            }

            var number = Convert.ToInt32(session);
            if (guess > number)
            {
                return View(new Message() { Value = Messages.IsGreaterThan });
            }
            else if (guess < number)
            {
                return View(new Message() { Value = Messages.IsLowerThan });
            }
            else
            {
                return View(new Message() { Value = Messages.IsEqual });
            }
        }
    }
}