using BusinessLayer.Concete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Contact P)
        {
            cm.BLContactAdd(P);
            return View();
        }
    }
}