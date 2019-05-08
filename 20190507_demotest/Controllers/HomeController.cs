using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20190507_demotest.Models;
namespace _20190507_demotest.Controllers
{
    public class HomeController : Controller
    {
        betterbetterEntities db = new betterbetterEntities();
        // GET: Home
        public ActionResult Index()
        {
            var query = from pick in db.totbooklists.Take(4)
                        orderby pick.booklistid descending
                        select pick;
            return View(query.ToList());
        }
    }
}