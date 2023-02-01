using BusinessLayer.Concrete;
using Core_Project.Areas.Writer.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Threading.Tasks;

namespace Core_Project.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.Mail = values.Email;
            model.PictureUrl = values.ImageUrl;
            return View(values);
        }
        public PartialViewResult NavbarPartial()
        {
           
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());

            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;

            messageManager.Tadd(p);
            return PartialView();
        }
    }
}
