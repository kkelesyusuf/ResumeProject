using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        DBResumeEntities1 db = new DBResumeEntities1();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
    }
}