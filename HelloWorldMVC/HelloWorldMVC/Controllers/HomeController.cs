﻿using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var studentModel = new Student();

            return View("Index",studentModel);
        }

        public ActionResult SayHello(Student student)
        {
            student.FirstName = student.FirstName.ToUpperInvariant();
            return View("SayHello",student);
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
    }
}