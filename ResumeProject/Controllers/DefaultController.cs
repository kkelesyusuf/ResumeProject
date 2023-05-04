﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        DBResumeEntities1 db = new DBResumeEntities1();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTechnology()
        {
            var values = db.TblTechnology.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCounter()
        {
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.avgTecnologyValue = db.TblTechnology.Average(x => x.TechnologyValue);
            ViewBag.happyCustomer = 23;
            return PartialView();
        }
        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBrands()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}