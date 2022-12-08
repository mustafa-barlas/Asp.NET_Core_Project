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

            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            
            experienceManager.Tadd(experience);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.Tdelete(values);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {

            var values = experienceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {

         
            experienceManager.Tupdate(experience);
            return RedirectToAction("Index");
        }

    }
}
