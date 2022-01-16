using BusinessLayer.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var categorycalues = cm.GetAll();
            return View(categorycalues);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categorycalues = cm.GetAll();
            return PartialView(categorycalues);
        }
    }
}