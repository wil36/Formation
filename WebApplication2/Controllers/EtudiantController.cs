using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EtudiantController : Controller
    {
        public IActionResult Index()
        {
            //Passage par le viewbag
            /* ViewBag.Message = "Hello from EtudiantController";
             ViewBag.EtudiantsList = GetEtudiants();
             ViewBag.EtudiantsCount = GetEtudiants().Count;*/

            //Passage par le ViewData
            ViewData["Message"] = "Hello form etudiant";
            ViewData["EtudiantsCount"] = GetEtudiants().Count();
            ViewData["EtudiantsList"] = GetEtudiants();
            return View();
        }

        public List<EtudiantModel> GetEtudiants()
        {
            var etudiants = new List<EtudiantModel>
            {
                new EtudiantModel { Id = 1, Name = "Alice", Amount = 1000.50 },
                new EtudiantModel { Id = 2, Name = "Bob", Amount = 1500.75 },
                new EtudiantModel { Id = 3, Name = "Charlie", Amount = 2000.00 }
            };
            return etudiants;
        }

        [Route("/etudiant/details/{id}")]
        //[Route("~/")]
        public IActionResult Details(int id)
        {
            if (TempData["Message"] == null)
            {
                return RedirectToAction("Index", "Etudiant");
            }

            ViewBag.Message = TempData["Message"].ToString();
            return View();
        }
    }



}
