using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Project.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "parasors@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "parasors@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id); 
            return View(values);
        }
        public IActionResult AdminDeleteMessage(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.Tdelete(values);
            return RedirectToAction("SenderMessageList");

        }
        [HttpGet]
        public IActionResult AdminMessageAdd()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AdminMessageAdd(WriterMessage p)
        {
            p.Sender = "parasors@gmail.com";
            p.SenderName = "mustafa barlas";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context context = new Context();
            var userNameAndSurname = context.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name +" "+ y.Surname).FirstOrDefault();
            p.ReceiverName = userNameAndSurname;
            writerMessageManager.Tadd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
