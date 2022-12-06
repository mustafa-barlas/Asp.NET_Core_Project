using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            ViewBag.d1 = "Proje Listesi";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Ekleme";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.d1 = "Proje Listesi";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Ekleme";
            return View();  
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            portfolioManager.Tadd(portfolio);
            return RedirectToAction("Index");
        }
    }
}
