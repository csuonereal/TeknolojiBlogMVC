using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiBlogMVC.Models.entityframework;

namespace TeknolojiBlogMVC.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        public ActionResult Index()
        {
            var val = db.tbl_about.ToList();
            return View(val);
        }
    }
}