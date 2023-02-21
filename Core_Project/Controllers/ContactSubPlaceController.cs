using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactSubPlaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        
        [HttpGet]
        public IActionResult GetDetails()
        {

            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDetails(Contact contact)
        {
            
            contactManager.Tupdate(contact);
            return RedirectToAction("Index","Dashboard");
        }

    }
}
