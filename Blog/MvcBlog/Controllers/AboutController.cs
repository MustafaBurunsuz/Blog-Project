using BusinessLayer.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
           var aboutcontentlist = abm.GetAll();

            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {

            return PartialView();

        }
    }
}