using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult PreferdLanguageCookie()
        {
            string? language = Request.Cookies["PrefLang"];// Read Cookie

            if (!string.IsNullOrEmpty(language))
            {
                ViewBag.Language = language;
            }
            return View();
        }
    
        public IActionResult SetLanguageCookie(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Append("prefLang", lang, option);
            }
            return RedirectToAction(nameof(PreferdLanguageCookie));
        }
            
    }
}
