using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiBlogMVC.Models.entityframework;
using TeknolojiBlogMVC.Models;

namespace TeknolojiBlogMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        BlogAndComment bc = new BlogAndComment();
        public ActionResult Index()
        {
            var val = db.tbl_blog.ToList();
            return View(val);
        }
        public ActionResult BlogDetails(int id)
        {
            bc.valblog = db.tbl_blog.Where(m => m.BlogId == id).ToList();
            bc.valcomment = db.tbl_comment.OrderByDescending(m => m.CommentId).Where(n => n.Blog == id & n.Confirmation==true);
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.dgr = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(tbl_comment p)
        {
            p.Confirmation = false;
            db.tbl_comment.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}