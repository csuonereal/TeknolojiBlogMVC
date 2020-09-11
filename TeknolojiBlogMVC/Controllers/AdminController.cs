using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiBlogMVC.Models.entityframework;

namespace TeknolojiBlogMVC.Controllers
{
    public class AdminController : Controller
    {
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminBlogs()
        {
            var val = db.tbl_blog.ToList();
            return View(val);
        }
        [HttpGet]
        public ActionResult InsertBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertBlog(tbl_blog p)
        {
            p.ReleaseDate = DateTime.Today.ToShortDateString();
            db.tbl_blog.Add(p);
            db.SaveChanges();
            return RedirectToAction("AdminBlogs");
        }
        public ActionResult DeleteBlog(int id)
        {
            var val = db.tbl_blog.Find(id);
            db.tbl_blog.Remove(val);
            db.SaveChanges();
            return RedirectToAction("AdminBlogs");
        }
    }
}