using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypeLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            return View();
        }
    }
}
