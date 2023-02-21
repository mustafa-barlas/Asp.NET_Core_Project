using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());


        public IActionResult Index()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
        
        public IActionResult DeleteFeature(int id)
        {
            var values = featureManager.TGetByID(id);
            featureManager.Tdelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var values = featureManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            FeatureValidator validations = new FeatureValidator();
            ValidationResult results = validations.Validate(feature);
            if (results.IsValid)
            {
                featureManager.Tupdate(feature);
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
