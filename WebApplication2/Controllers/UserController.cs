using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult login()
        {
            HttpContext.Session.SetString("username", "Wil");
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            var username = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Username = username;
            return View();
        }

        public IActionResult logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }

        public IActionResult QueryTest()
        {
            string name = "Wil";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
            {
                name = HttpContext.Request.Query["name"];
            }
            ViewBag.Name = name;
            return View();
        }

        public IActionResult UserDetail() { 
            var user =new LoginViewModel(){ Username = "Wilfrid", Password = "123456"};
            return View(user);
        }
    }
}
