using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
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
