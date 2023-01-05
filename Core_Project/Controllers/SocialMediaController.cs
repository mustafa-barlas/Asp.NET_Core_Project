using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());

        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.Tadd(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.Tdelete(values);
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.Tupdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
