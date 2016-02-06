using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            Trace.TraceInformation("Hello from home page " + DateTime.UtcNow.ToLongTimeString());

            return View();
        }
    }
}
