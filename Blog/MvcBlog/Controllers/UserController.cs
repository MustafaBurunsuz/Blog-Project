using BusinessLayer.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class UserController : Controller
    {
        UserProfileManager userprofile = new UserProfileManager();
        // GET: AuthorLogin
        public ActionResult Index(string mail)
        {
            mail = (string)Session["Mail"]; 
            var profilevalues = userprofile.GetAuthorByMail(mail);
            return View(profilevalues);
        }
       
    }
}