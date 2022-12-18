using Core_Project.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
