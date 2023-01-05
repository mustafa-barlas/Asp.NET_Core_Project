using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.Tdelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialManager.Tupdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
