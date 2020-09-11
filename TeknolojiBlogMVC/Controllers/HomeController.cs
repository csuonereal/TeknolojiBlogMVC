using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiBlogMVC.Models.entityframework;
namespace TeknolojiBlogMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        public ActionResult Index()
        {
            var values = db.tbl_blog.ToList();
            return View(values);
        }
        public PartialViewResult LastPost()
        {
            var values = db.tbl_blog.OrderByDescending(m => m.BlogId).Take(1).ToList();
            return PartialView(values);
        }
        public PartialViewResult RecentPost()
        {
            var values = db.tbl_blog.OrderByDescending(m=>m.BlogId).Take(8).ToList();
            return PartialView(values);
        }
    }
}