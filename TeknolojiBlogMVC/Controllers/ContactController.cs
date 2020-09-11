using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiBlogMVC.Models.entityframework;

namespace TeknolojiBlogMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {

            return View();
        }
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        [HttpPost]
        public ActionResult Index(tbl_contact p)
        {
            db.tbl_contact.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}