﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_RecruitmentComplete.Controllers
{
    public class RecruitmentController : Controller
    {
        public ActionResult ListCandidate()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListStaff()
        {
            return View();
        }
    }
}