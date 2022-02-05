using BusinessLayer.Concete;
using DataAccessLayer.Concrete;
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
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userprofile.GetAuthorByMail(p);

            return PartialView(profilevalues);
        }
        public ActionResult BlogList(string p)
        {
            p = (string)Session["Mail"];
            Context c = new Context();
            int id = c.Authors.Where(x => x.Mail == p).Select(y => y.AuthorID).FirstOrDefault();
            var blogs = userprofile.GetBlogsByAuthor(id);

            return View(blogs);
        }

    }
}