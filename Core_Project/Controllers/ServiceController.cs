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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.Tdelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddService() {

           
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);
            if (results.IsValid)
            {
                serviceManager.Tadd(service);
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

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = serviceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);
            if (results.IsValid)
            {
                serviceManager.Tupdate(service);
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
