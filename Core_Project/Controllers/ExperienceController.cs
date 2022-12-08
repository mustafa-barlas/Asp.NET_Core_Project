using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            
            ExperienceValidator validations = new ExperienceValidator();    
            ValidationResult results = validations.Validate(experience);
            if (results.IsValid)
            {
                experienceManager.Tadd(experience);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(experience);
            if (results.IsValid)
            {
                experienceManager.Tupdate(experience);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); 
                }
            }
            return View();
        }

    }
}
