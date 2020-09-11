using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknolojiBlogMVC.Models.entityframework;

namespace TeknolojiBlogMVC.Models
{

    public class BlogAndComment
    {
        MVCBlogTeknolojiEntities db = new MVCBlogTeknolojiEntities();
        public IEnumerable<tbl_blog> valblog { get; set; }
        public IEnumerable<tbl_comment> valcomment { get; set; }
    }
}