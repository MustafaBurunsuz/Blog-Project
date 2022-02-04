using BusinessLayer.Concete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogmanager = new BlogManager();
        AuthorManager authormanager = new AuthorManager();
        // GET: Author
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetails = blogmanager.GetBlogByID(id);
            return PartialView(authordetails);
        }
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogmanager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var aurhorblogs = blogmanager.GetBogByAuthor(blogauthorid);
            return PartialView(aurhorblogs);
        }
        public ActionResult AuthorList()
        {
           var authorlists = authormanager.GetAll();
            return View(authorlists);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            authormanager.AddAuthorBL(p);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authormanager.FindAuthor(id);
            return View(author);

        }
        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            authormanager.UpdateAuthor(p);
            return RedirectToAction("AuthorList");
        }
    }
}