using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello from CustomerController1";
            return View();
        }
    }
}
