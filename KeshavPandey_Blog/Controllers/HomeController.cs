﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeshavPandey_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            ViewBag.Message = "You can reach out to me via the channels below.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewData["Message"] = "Want to read what i got to say?";

            return View();
        }

        public ActionResult Twitter()
        {
            ViewData["Message"] = "Attck of the Twitteratzi!!";

            return View();
        }
    }
}