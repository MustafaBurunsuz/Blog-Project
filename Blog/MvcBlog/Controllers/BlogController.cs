﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blogs
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList()
        {

            return PartialView();
        }
        public PartialViewResult FeaturedPost()
        {

            return PartialView();
        }
        public PartialViewResult OtherFeaturedPosts()
        {

            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {

            return PartialView();
        }
    }
}