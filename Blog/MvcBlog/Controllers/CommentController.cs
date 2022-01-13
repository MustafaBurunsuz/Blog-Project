using BusinessLayer.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager();
        // GET: Comment
        public PartialViewResult CommentList(int id)
        {   
            var commentlist = cm.CommentByBlock(id);
            ViewBag.CommentCount = commentlist.Count();
            return PartialView(commentlist);
        }
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}