﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBResumeEntities1 db = new DBResumeEntities1();
        public ActionResult Index()
        {
            //ViewBag.skillCount = db.TblSkill.Count();
            //ViewBag.countProjeTalebi = db.countProjeTalebi().FirstOrDefault();
            ViewBag.technologyCount = db.TblTechnology.Count();
            ViewBag.javaValue = db.TblTechnology.Where(x => x.TechnologyTitle == "Java").Select(y => y.TechnologyValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContact.Count();
            ViewBag.subjectTesekkur = db.TblContact.Where(x => x.Subject == 1).Count();
            ViewBag.sumTechnologyValue = db.TblTechnology.Sum(x => x.TechnologyValue);
            ViewBag.averageTechnologyValue = db.TblTechnology.Average(x => x.TechnologyValue);
            ViewBag.GetBy3ID = db.TblSkill.Where(x => x.SkillID == 3).Select(y => y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.TblTechnology.Max(x => x.TechnologyValue);
            return View();
        }
    }
}