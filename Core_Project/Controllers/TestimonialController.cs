﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.Tadd(p);
            return RedirectToAction("Index");
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
