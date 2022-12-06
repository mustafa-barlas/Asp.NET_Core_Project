using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Core_Project.Controllers
{
    public class ExperienceController : Controller
    {
       
       ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            ViewBag.d1 = "Deneyim Listesi";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Ekleme"; 
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.d1 = "Deneyim Listesi";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            
            experienceManager.Tadd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.d1 = "Deneyim Listesi";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Listesi";
            var values = experienceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {

         
            experienceManager.Tupdate(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.Tdelete(values);
            return RedirectToAction("Index");

        }
    }
}
