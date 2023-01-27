using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent 
    {
        WriterUser user = new WriterUser();
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = writerMessageManager.TGetList().Count;
            

            string p = "parasors@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            return View(values);  
        }
    }
}
