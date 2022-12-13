using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class LastFiveProjects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
