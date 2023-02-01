using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Project.ViewComponents
{
    public class ImagePartForDefault : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public ImagePartForDefault(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.ImageUrl;
            ViewBag.v2 = values.Name +" "+ values.Surname;   
            return View(values);
        }
    }
}
